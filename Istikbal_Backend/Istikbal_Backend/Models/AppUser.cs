using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Istikbal_Backend.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
