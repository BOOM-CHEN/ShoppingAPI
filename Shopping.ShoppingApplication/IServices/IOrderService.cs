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
    public interface IOrderService : IBaseServices<Order>
    {
        public Task InsertOrderAsync(Order order);
        public Task DeleteOrderAsync(Expression<Func<Order, bool>> exp);
        public Task DeleteAllOrderAsync();
        public Task<Order> GetOrderAsync(Expression<Func<Order, bool>> exp);
        public Task<List<Order>> GetOrderListAsync(Expression<Func<Order, bool>> exp);
        public Task<List<Order>> GetAllOrdersAsync();
    }
}
