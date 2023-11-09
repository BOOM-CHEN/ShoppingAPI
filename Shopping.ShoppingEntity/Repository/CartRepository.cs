using Shopping.ShoppingEntity.Entity;
using Shopping.ShoppingEntity.IRepository;
using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using Shopping.ShoppingEntity.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Repository
{
    public class CartRepository : BaseRepository<ShoppingCart>, ICartRepository
    {
        private readonly IBaseRepository<ShoppingCart> _baseRepository;
        public CartRepository(ShoppingDbContext shoppingDbContext,IBaseRepository<ShoppingCart> baseRepository) : base(shoppingDbContext)
        {
            _baseRepository = baseRepository;
        }

        public async Task AddCartAsync(ShoppingCart cart)
        {
            await _baseRepository.InsertAsync(cart);
        }

        public async Task DeleteAllCartAsync()
        {
            await _baseRepository.DeleteAllAsync();
        }

        public async Task DeleteCartAsync(Expression<Func<ShoppingCart,bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }

        public async Task<List<ShoppingCart>> GetAllCartAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<ShoppingCart> GetCartAsync(Expression<Func<ShoppingCart, bool>> exp)
        {
            return await _baseRepository.FindAsync(exp);
        }
    }
}
