﻿using Cil.Todo.Data.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace Cil.Todo.Data
{
    public partial class CilDataContext : DbContext
    {
        public CilDataContext()
            : base("name=DefaultDB")
        {
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CT");

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type =>
                    type.BaseType != null
                    && type.BaseType.IsGenericType
                    && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)
                );

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }


            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            /// TODO : Add CreatedUserId and UpdatedUserId 
            /// http://stackoverflow.com/questions/34578573/entity-framework-7-audit-log
            var addedAuditedEntities = ChangeTracker.Entries<IAuditEntity>()
              .Where(p => p.State == EntityState.Added)
              .Select(p => p.Entity);

            var modifiedAuditedEntities = ChangeTracker.Entries<IAuditEntity>()
              .Where(p => p.State == EntityState.Modified)
              .Select(p => p.Entity);

            var now = DateTime.UtcNow;

            foreach (var added in addedAuditedEntities)
            {
                added.CreatedDate = now;
                added.UpdatedDate = now;
            }

            foreach (var modified in modifiedAuditedEntities)
            {
                modified.UpdatedDate = now;
            }

            return base.SaveChanges();
        }

    }
}
