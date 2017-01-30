using System;

namespace Cil.Todo.Data.Domain
{
    public partial class Category : BaseEntity, IAuditEntity, IDeletedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ParentCategoryId { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public short DisplayOrder { get; set; }

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
