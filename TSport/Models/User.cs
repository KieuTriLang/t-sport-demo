using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TSport.Models
{
    public class User : IdentityUser
    {
        public string DisplayName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
