using System;
using System.ComponentModel.DataAnnotations;

namespace Cil.Todo.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public Guid RowId { get; set; }
    }
}
