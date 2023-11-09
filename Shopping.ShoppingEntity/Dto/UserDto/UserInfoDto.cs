using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Dto.UserDto
{
    public class UserInfoDto
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhoneNumber { get; set; }
        public string? UserRecieveAddress { get; set; }
        public string? UserAvatar { get; set; }
        public string? Role { get; set; }
    }
}
