using Cil.Todo.Data.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Mapping
{
    public partial class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {

            ToTable("CTB.Category");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.Description).IsOptional().HasMaxLength(300);
            Property(c => c.ParentCategoryId).IsOptional();
            Property(c => c.DisplayOrder).HasColumnType("SMALLINT").IsRequired();
        }
    }
}
