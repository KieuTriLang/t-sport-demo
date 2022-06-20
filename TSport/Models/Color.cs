using System.Collections.Generic;

namespace TSport.Models
{
    public class Color
    {
        public Color()
        {
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string HexCode { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
