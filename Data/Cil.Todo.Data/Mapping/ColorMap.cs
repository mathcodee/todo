using Cil.Todo.Data.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cil.Todo.Data.Mapping
{
    public partial class ColorMap : EntityTypeConfiguration<Color>
    {
        public ColorMap()
        {
            ToTable("CTD.Color");
            Property(c => c.Name).IsRequired().HasMaxLength(20);
            Property(c => c.HexCode).HasMaxLength(6);
            Property(c => c.Red).IsOptional();
            Property(c => c.Green).IsOptional();
            Property(c => c.Blue).IsOptional();
            Property(c => c.DisplayOrder).HasColumnType("SMALLINT").IsRequired();
        }
    }
}
