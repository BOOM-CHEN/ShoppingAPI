using Shopping.ShoppingApplication.IServers.IBase;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingApplication.IServices
{
    public interface ICartService : IBaseServices<ShoppingCart>
    {
        public Task AddCartAsync(ShoppingCart cart);
        public Task DeleteCartAsync(Expression<Func<ShoppingCart, bool>> exp);
        public Task DeleteAllCartAsync();
        public Task<List<ShoppingCart>> GetAllCartAsync();
        public Task<ShoppingCart> GetCartAsync(Expression<Func<ShoppingCart, bool>> exp);
    }
}
