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
    public class OrderService : BaseServices<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IBaseRepository<Order> baseRepository , IOrderRepository orderRepository) : base(baseRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task DeleteAllOrderAsync()
        {
            await _orderRepository.DeleteAllAsync();
        }

        public async Task DeleteOrderAsync(Expression<Func<Order, bool>> exp)
        {
            await _orderRepository.DeleteOrderAsync(exp);
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }

        public async Task<List<Order>> GetOrderListAsync(Expression<Func<Order, bool>> exp)
        {
            return await _orderRepository.GetOrderListAsync(exp);
        }
        public async Task<Order> GetOrderAsync(Expression<Func<Order, bool>> exp)
        {
            return await _orderRepository.GetOrderAsync(exp);
        }

        public async Task InsertOrderAsync(Order order)
        {
            await _orderRepository.InsertOrderAsync(order);
        }
    }
}
