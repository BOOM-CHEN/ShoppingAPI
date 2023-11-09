using Microsoft.EntityFrameworkCore;
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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly IBaseRepository<Order> _baseRepository;
        private readonly ShoppingDbContext _shoppingDbContext;
        public OrderRepository(ShoppingDbContext shoppingDbContext,IBaseRepository<Order> baseRepository) : base(shoppingDbContext)
        {
            _baseRepository = baseRepository;
            _shoppingDbContext = shoppingDbContext;
        }

        public async Task DeleteAllOrderAsync()
        {
            await _baseRepository.DeleteAllAsync();
        }

        public async Task DeleteOrderAsync(Expression<Func<Order, bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _baseRepository.GetAllAsync();
        }
        public async Task<List<Order>> GetOrderListAsync(Expression<Func<Order, bool>> exp)
        {
            return await _baseRepository.GetListAsync(exp);
        }
        public async Task<Order> GetOrderAsync(Expression<Func<Order, bool>> exp)
        {
            return await _baseRepository.FindAsync(exp);
        }

        public async Task InsertOrderAsync(Order order)
        {
            await _baseRepository.InsertAsync(order);
        }
    }
}
