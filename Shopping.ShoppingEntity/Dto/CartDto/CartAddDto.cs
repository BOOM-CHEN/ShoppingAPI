using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Dto.CartDto
{
    public class CartAddDto
    {
        public required Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public int ProductQuantity { get; set; }
    }
}
