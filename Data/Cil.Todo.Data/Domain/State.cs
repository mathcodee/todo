using System.Collections.Generic;

namespace Cil.Todo.Data.Domain
{
    public partial class State : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
