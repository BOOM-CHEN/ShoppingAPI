using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingEntity.Dto.OrderDto;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingApplication.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class OrderControllers : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public OrderControllers(IOrderService orderService, IUserService userService,IMapper mapper)
        {
            _orderService = orderService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("AddOrder")]
        public async Task<MessageModel<string>> AddOrder(OrderAddDto orderAddDto)
        {
            var user = await _userService.GetUserByIdAsync(orderAddDto.UserId);
            var order = _mapper.Map<Order>(orderAddDto);
            order.User = user;
            await _orderService.InsertOrderAsync(order);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "添加订单成功"
            };
        }
        [HttpDelete("DeleteAllOrder")]
        public async Task<MessageModel<string>> DeleteAllOrder()
        {
            await _orderService.DeleteAllOrderAsync();
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除全部订单成功"
            };
        }

        [HttpDelete("DeleteOrder")]
        public async Task<MessageModel<string>> DeleteOrder(Guid id)
        {
            var entity = await _orderService.GetOrderAsync(x => x.Id == id);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "该订单不存在"
                };
            }
            await _orderService.DeleteAsync(x => x.Id == id);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "订单删除成功"
            };
        }

        /// <summary>
        /// 待付款
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOrderOfPendingPayment")]
        public async Task<List<Order>> GetAllOrderOfPendingPayment()
        {
            return await _orderService.GetOrderListAsync(x => x.OrderStatus == "PendingPayment");
        }

        /// <summary>
        /// 已付款
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllOrderOfPaid")]
        public async Task<List<Order>> GetAllOrderOfPaid()
        {
            return await _orderService.GetOrderListAsync(x => x.OrderStatus == "Paid");
        }

        [HttpGet("GetAllOrder")]
        public async Task<List<Order>> GetAllOrder()
        {
            return await _orderService.GetAllOrdersAsync();
        }
    }
}
