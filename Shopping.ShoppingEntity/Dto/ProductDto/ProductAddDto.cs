using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Dto.ProductDto
{
    public class ProductAddDto
    {
        public string? ProductImage { get; set; }
        public required string ProductName { get; set; }
        public required string ProductDescription { get; set; }
        public required double ProductPrice { get; set; }
        public double ProductDiscount { get; set; }//折扣
        public required int ProductInventory { get; set; }//库存
        public required string ProductCategory { get; set; }
    }
}
