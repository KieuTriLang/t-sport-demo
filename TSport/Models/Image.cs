using System.Collections.Generic;

namespace TSport.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
