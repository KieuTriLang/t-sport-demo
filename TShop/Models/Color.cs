namespace TShop.Models
{
    public class Color
    {
        public Color()
        {
            this.ColorProducts = new HashSet<ColorProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ColorProduct> ColorProducts { get; set; }
    }
}
