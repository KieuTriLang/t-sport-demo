﻿namespace TShop.Models
{
    public class OrderHistory
    {
        public OrderHistory()
        {
            this.OHProducts = new HashSet<OHProduct>();
        }
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public IEnumerable<OHProduct> OHProducts { get; set; }
        public string CouponCode { get; set; }
        public string ToLocation { get; set; }
        public string ReceiverPhone { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
