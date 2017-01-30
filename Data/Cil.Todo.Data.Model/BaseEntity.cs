using System;
using System.ComponentModel.DataAnnotations;

namespace Cil.Todo.Data.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public Guid RowId { get; set; }
    }
}
