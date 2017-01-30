using Cil.Todo.Data.Model.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Model.Mapping
{
    public partial class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("CTD.Country");
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.Code).IsRequired();
            Property(p => p.DisplayOrder).IsRequired();
        }
    }
}
