namespace Cil.Todo.Data.Model.Domain
{
    public partial class City : BaseEntity
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int DisplayOrder { get; set; }
    }
}
