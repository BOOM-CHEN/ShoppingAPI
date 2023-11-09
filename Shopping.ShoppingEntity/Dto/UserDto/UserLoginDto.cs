using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Dto.UserDto
{
    public class UserLoginDto
    {
        public required string UserEmail { get; set; }
        public required string UserPassword { get; set; }
    }
}
