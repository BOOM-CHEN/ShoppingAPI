using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.IRepository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        public Task InsertOrderAsync(Order order);
        public Task DeleteOrderAsync(Expression<Func<Order,bool>> exp);
        public Task DeleteAllOrderAsync();
        public Task<Order> GetOrderAsync(Expression<Func<Order, bool>> exp);
        public Task<List<Order>> GetOrderListAsync(Expression<Func<Order, bool>> exp);
        public Task<List<Order>> GetAllOrdersAsync();
    }
}
