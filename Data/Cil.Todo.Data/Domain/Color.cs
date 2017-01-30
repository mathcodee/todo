namespace Cil.Todo.Data.Domain
{
    public partial class Color : BaseEntity
    {
        public string Name { get; set; }
        public string HexCode { get; set; }
        public byte? Red { get; set; }
        public byte? Green { get; set; }
        public byte? Blue { get; set; }
        public short DisplayOrder { get; set; }
    }
}
