namespace Cil.Todo.Data.Model.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cil.Todo.Data.Model.CilDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cil.Todo.Data.Model.CilDataContext context)
        {
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Country.AddOrUpdate(p => p.Code,
                new Country { Name = "Türkiye", Code = "90", DisplayOrder = -100, RowId = Guid.NewGuid() });
        }
    }
}
