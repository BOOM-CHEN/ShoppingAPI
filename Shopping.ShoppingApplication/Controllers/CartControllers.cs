using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingEntity.Dto.CartDto;
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
    public class CartControllers : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        private readonly IUserService _userService;

        public CartControllers(ICartService cartService,IMapper mapper, IProductService productService, IUserService userService)
        {
            _cartService = cartService;
            _mapper = mapper;
            _productService = productService;
            _userService = userService;
        }

        [HttpPost("CartAdd")]
        public async Task<MessageModel<string>> CartAdd(CartAddDto cartAddDto)
        {
            var entity = _mapper.Map<ShoppingCart>(cartAddDto);
            var product = await _productService.FindProductAsync(x => x.Id == cartAddDto.ProductId);
            var user = await _userService.GetUserByIdAsync(entity.UserId);
            if(user == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "购物车缺失主人"
                };
            }
            if (product == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "未找到该产品,无法加入到购物车中"
                };
            }
            await _cartService.AddCartAsync(entity);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "成功添加到购物车"
            };
        }

        [HttpDelete("CartDeleteAll")]
        public async Task CartDeleteAll()
        {
            await _cartService.DeleteAllAsync();
        }

        [HttpDelete("CartDeleteById")]
        public async Task<MessageModel<string>> CartDeleteById(Guid id)
        {
            var entity = await _cartService.GetCartAsync(x => x.Id == id);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "购物车中找不到该产品"
                };
            }
            await _cartService.DeleteAsync(x => x.Id == id);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }
        [HttpGet("GetAllCart")]
        public async Task<List<ShoppingCart>> GetAllCart()
        {
            return await _cartService.GetAllCartAsync();
        }
    }
}
