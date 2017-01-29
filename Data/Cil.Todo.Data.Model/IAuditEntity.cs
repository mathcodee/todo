using System;

namespace Cil.Todo.Data.Model
{
    public interface IAuditEntity
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
        int UpdatedUserId { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
