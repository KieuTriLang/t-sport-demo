﻿using System.Collections.Generic;

namespace TSport.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
