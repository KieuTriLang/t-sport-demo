﻿using System;

namespace TSport.Models
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public DateTime TimePosted { get; set; }
    }
}
