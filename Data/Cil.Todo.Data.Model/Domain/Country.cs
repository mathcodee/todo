using System.Collections.Generic;

namespace Cil.Todo.Data.Model.Domain
{
    public partial class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<State> States { get; set; }
    }
}
