using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyShop.Domain.Models
{
    public class User : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
    }
}
