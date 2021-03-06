using System.Collections.Generic;

namespace TSport.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string HexCode { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
