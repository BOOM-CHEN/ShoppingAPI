using Shopping.ShoppingEntity.Models.TKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class User : RootTKey<Guid>
    {
        public required string UserName { get; set; }    
        public required string UserEmail { get; set; }
        public required string UserPassword { get; set; }
        public required string RegisterTime { get; set; }
        public string? UserPhoneNumber{ get; set; }
        public string? UserRecieveAddress { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }
        public string? UserAvatar { get; set; }
        public Password? Passwords { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
