using Cil.Todo.Data.Enum;
using System;
using System.Collections.Generic;

namespace Cil.Todo.Data.Domain
{
    public partial class User : BaseEntity, IAuditEntity, IDeletedEntity
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public byte GenderId { get; set; }
        public GenderType Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        private ICollection<Category> _categories;
        public ICollection<Category> Categories
        {
            get { return _categories ?? (_categories = new List<Category>()); }
            set { _categories = value; }
        }

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
