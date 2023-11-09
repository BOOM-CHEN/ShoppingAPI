using Shopping.ShoppingEntity.Models.TKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class Product :RootTKey<Guid>
    {
        public string? ProductImage { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public required double ProductPrice { get; set; }
        public string? ProductDate { get; set; }
        public double ProductDiscount { get; set; }//折扣
        public required int ProductInventory { get; set; }//库存
        public required string ProductCategory { get; set; }
        public Guid? ShoppingCartId { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }
    }
}
