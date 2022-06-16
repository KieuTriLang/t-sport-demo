namespace TShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public IEnumerable<Product> WishList { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
