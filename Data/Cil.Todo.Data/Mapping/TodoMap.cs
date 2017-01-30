using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Mapping
{
    public partial class TodoMap : EntityTypeConfiguration<Cil.Todo.Data.Domain.Todo>
    {
        public TodoMap()
        {
            ToTable("CTB.Todo");
            Property(t=> t.CategoryId).IsOptional();
            Property(t => t.Title).IsRequired().HasMaxLength(300);
            Property(t => t.Description).IsOptional().IsMaxLength();
            Property(t => t.Priority).IsOptional();
            Property(t => t.StartDate).IsOptional();
            Property(t => t.DueDate).IsOptional();
            Property(t => t.DoneDate).IsOptional();
            Property(t => t.IsDone).IsRequired();
            Property(t => t.IsCancelled).IsRequired();
            Property(t => t.DisplayOrder).IsRequired();
            Property(t => t.ColorId).IsOptional();
        }
    }
}
