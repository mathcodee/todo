using Cil.Todo.Data.Model.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cil.Todo.Data.Model.Mapping
{
    public partial class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("CTB.User");
            Ignore(p => p.Gender);

            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.MiddleName).IsOptional().HasMaxLength(60);
            Property(p => p.LastName).IsRequired().HasMaxLength(60);
            Property(p => p.GenderId).HasColumnType("SMALLINT").IsRequired();

            Property(p => p.Username).IsRequired().HasMaxLength(128);
            Property(p => p.Password).IsRequired().HasMaxLength(128);
            Property(p => p.PasswordSalt).IsRequired().HasMaxLength(60);
            Property(p => p.IsActive).IsRequired();
            Property(p => p.IsApproved).IsRequired();
            Property(p => p.CityId).IsRequired();

            HasRequired(p => p.City)
                .WithMany(m => m.Id)
                .HasForeignKey(u => u.CityId);
        }
    }
}
