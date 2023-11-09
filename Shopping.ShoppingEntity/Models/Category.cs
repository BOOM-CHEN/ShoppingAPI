using Shopping.ShoppingEntity.Models.TKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Models
{
    public class Category : RootTKey<Guid>
    {
        public string? CategoryName { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }
    }
}
