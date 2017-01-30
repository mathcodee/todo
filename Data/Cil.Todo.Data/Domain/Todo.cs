using System;

namespace Cil.Todo.Data.Domain
{
    public partial class Todo : BaseEntity, IAuditEntity, IDeletedEntity
    {
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsCancelled { get; set; }
        public int DisplayOrder { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }

        #region IAuditEntity
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        #endregion

        #region IDeletedEntity
        public bool IsDeleted { get; set; }
        #endregion
    }
}
