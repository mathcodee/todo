using System.Collections.Generic;

namespace Cil.Todo.Data.Domain
{
    public partial class City : BaseEntity
    {
        private ICollection<User> _users;

        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public short DisplayOrder { get; set; }

        public ICollection<User> Users
        {
            get
            {
                return _users ?? (_users = new List<User>());
            }
            protected set
            {
                _users = value;
            }
        }
    }
}
