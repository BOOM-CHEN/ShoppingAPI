using Shopping.ShoppingEntity.Models.TKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class ShoppingCart : RootTKey<Guid>
    {
        public required Guid UserId { get; set; }
        public Guid? ProductId { get; set; }
        public int? ProductQuantity { get; set; }
        public List<Product>? Products { get; set; }
    }
}
