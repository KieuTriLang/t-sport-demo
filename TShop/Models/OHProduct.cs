namespace TShop.Models
{
    public class OHProduct
    {
        public int Id { get; set; }
        public OrderHistory OrderHistory { get; set; }
        public int OrderHistoryId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
