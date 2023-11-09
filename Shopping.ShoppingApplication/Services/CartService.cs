using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingApplication.Services.Base;
using Shopping.ShoppingEntity.IRepository;
using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingApplication.Services
{
    public class CartService : BaseServices<ShoppingCart>, ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(IBaseRepository<ShoppingCart> baseRepository , ICartRepository cartRepository) : base(baseRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task AddCartAsync(ShoppingCart cart)
        {
            await _cartRepository.AddCartAsync(cart);
        }

        public async Task DeleteAllCartAsync()
        {
            await _cartRepository.DeleteAllCartAsync();
        }

        public async Task DeleteCartAsync(Expression<Func<ShoppingCart, bool>> exp)
        {
            await _cartRepository.DeleteAllAsync();
        }

        public async Task<List<ShoppingCart>> GetAllCartAsync()
        {
            return await _cartRepository.GetAllCartAsync();
        }

        public async Task<ShoppingCart> GetCartAsync(Expression<Func<ShoppingCart, bool>> exp)
        {
            return await _cartRepository.GetCartAsync(exp);
        }
    }
}
