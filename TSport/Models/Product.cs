using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TSport.Models
{
    public class Product
    {
        //public Product()
        //{
        //    this.Colors = new HashSet<Color>();
        //    this.Sizes = new HashSet<Size>();
        //    this.Reviews = new HashSet<Review>();
        //    this.Images = new HashSet<Image>();
        //}
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string Overeview { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int SalesOff { get; set; }
        public int Total { get; set; }
        public int InStock { get; set; }

        [JsonIgnore]
        public IEnumerable<Color> Colors { get; set; }
        [JsonIgnore]
        public IEnumerable<Size> Sizes { get; set; }
        [JsonIgnore]
        public IEnumerable<Review> Reviews { get; set; }
        [JsonIgnore]
        public IEnumerable<Image> Images { get; set; }
    }
}
