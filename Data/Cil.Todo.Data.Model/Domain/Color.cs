namespace Cil.Todo.Data.Model.Domain
{
    public partial class Color : BaseEntity
    {
        public string Name { get; set; }
        public string HexCode { get; set; }
        public byte? Red { get; set; }
        public byte? Green { get; set; }
        public byte? Blue { get; set; }
        public int DisplayOrder { get; set; }
    }
}
