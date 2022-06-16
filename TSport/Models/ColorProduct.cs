namespace TSport.Models
{
    public class ColorProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public string ImageUrl { get; set; }
    }
}
