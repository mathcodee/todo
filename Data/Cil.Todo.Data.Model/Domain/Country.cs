using System.Collections.Generic;

namespace Cil.Todo.Data.Model.Domain
{
    public partial class Country : BaseEntity
    {
        private ICollection<State> _states;

        public string Name { get; set; }
        public string Code { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<State> States
        {
            get
            {
                return _states ?? (_states = new List<State>());
            }
            protected set
            {
                _states = value;
            }
        }
    }
}
