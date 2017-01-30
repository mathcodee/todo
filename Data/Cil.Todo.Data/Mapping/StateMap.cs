using Cil.Todo.Data.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cil.Todo.Data.Mapping
{
    public partial class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            ToTable("CTD.State");
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(c => c.DisplayOrder).HasColumnType("SMALLINT").IsRequired();

            HasRequired(s => s.Country)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.CountryId);
        }
    }
}
