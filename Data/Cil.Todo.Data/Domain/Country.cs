using System.Collections.Generic;

namespace Cil.Todo.Data.Domain
{
    public partial class Country : BaseEntity
    {
        

        public string Name { get; set; }
        public string Code { get; set; }
        public short DisplayOrder { get; set; }

        private ICollection<State> _states;
        public ICollection<State> States
        {
            get { return _states ?? (_states = new List<State>()); }
            set { _states = value; }
        }
    }
}
