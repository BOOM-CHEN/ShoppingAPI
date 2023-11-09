using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingEntity.Dto.ProductDto;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingApplication.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductControllers : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductControllers(IProductService productService, IMapper mapper, ICategoryService categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpPost("InsertProduct")]
        [Authorize(Roles = "root,admin")]
        public async Task<MessageModel<string>> InsertProduct(ProductAddDto productAddDto)
        {
            var product = _mapper.Map<Product>(productAddDto);
            product.ProductDate = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss");
            var category = await _categoryService.GetCategoryAsync(c => c.CategoryName == product.ProductCategory);
            if(category == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "在选择类别时发生了异常错误"
                };
            }
            ProductCategory productCategory = new()
            {
                Product = product,
                Category = category
            };
            await _productService.InsertProductCategoryAsync(productCategory);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "添加成功"
            };
            
        }

        [HttpDelete("DeleteAllProduct")]
        [Authorize(Roles = "root,admin")]
        public async Task DeleteAllProduct()
        {
            await _productService.DeleteAllProductAsync();
        }

        [HttpDelete("DeleteProduct")]
        //[Authorize(Roles = "root,admin")]
        public async Task<MessageModel<string>> DeleteProductById(Guid id)
        {
            var entity = await _productService.FindProductAsync(x => x.Id == id);
            if (entity == null)
            {
                return new MessageModel<string>()
                { 
                    Status = 400,
                    Success = false,
                    Message = $"id为{id}的产品不存在"
                };
            }
            await _productService.DeleteProductAsync(x => x.Id == id);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }

        [HttpDelete("DeleteListProduct")]
        [Authorize(Roles = "root,admin")]
        public async Task<MessageModel<string>> DeleteListProduct(List<Product> products)
        {
            Product? entity = null;
            foreach (var product in products)
            {
                entity = await _productService.FindProductAsync(x =>x.Id == product.Id);
                if (entity == null)
                {
                    return new MessageModel<string>()
                    {
                        Status = 400,
                        Success = false,
                        Message = $"Id为{product.Id}的产品不存在"
                    };
                }
            }
            foreach (var product in products)
            {
                await _productService.DeleteProductAsync(x => x.Id == product.Id);
            }
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }

        [HttpPut("UpdateProduct")]
        public async Task<MessageModel<string>> UpdateProduct(Product product)
        {
            var entity = await _productService.FindProductAsync(x =>x.Id == product.Id);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "未找到需要更新的产品"
                };
            }
            entity = product;
            await _productService.UpdateProductAsync(entity);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "更新成功"
            };
        }

        #region 排序
        /// <summary>
        /// 获取所有产品
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllProduct")]
        public async Task<MessageModel<List<Product>>> GetAllProduct()
        {
            var entity = await _productService.GetAllProductAsync();
            return new MessageModel<List<Product>>()
            {
                Status = 200,
                Success = true,
                Data = entity
            };
        }

        /// <summary>
        /// 按价格排序
        /// </summary>
        /// <param name="codition"></param>
        /// <returns></returns>
        [HttpGet("GetProductPriceOrder")]
        public async Task<MessageModel<List<Product>>> GetProductPriceOrder(string codition)
        {
            var entities = await _productService.GetAllProductAsync();
            if(codition == "up")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderBy(x => x.ProductPrice).ToList()
                };
            }
            else if(codition == "down")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderByDescending(x => x.ProductPrice).ToList()
                };
            }
            else
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 400,
                    Success = false,
                    Message = "传递参数为'up'or'down'"
                };
            }
            
        }

        /// <summary>
        /// 按日期排序
        /// </summary>
        /// <param name="codition"></param>
        /// <returns></returns>
        [HttpGet("GetProductDateOrder")]
        public async Task<MessageModel<List<Product>>> GetProductDateOrder(string codition)
        {
            var entities = await _productService.GetAllProductAsync();
            if (codition == "up")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderBy(x => x.ProductDate).ToList()
                };
            }
            else if (codition == "down")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderByDescending(x => x.ProductDate).ToList()
                };
            }
            else
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 400,
                    Success = false,
                    Message = "传递参数为'up'or'down'"
                };
            }

        }

        /// <summary>
        /// 按库存排序
        /// </summary>
        /// <param name="codition"></param>
        /// <returns></returns>
        [HttpGet("GetProductInventoryOrder")]
        public async Task<MessageModel<List<Product>>> GetProductInventoryOrder(string codition)
        {
            var entities = await _productService.GetAllProductAsync();
            if (codition == "up")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderBy(x => x.ProductInventory).ToList()
                };
            }
            else if (codition == "down")
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 200,
                    Success = true,
                    Data = entities.OrderByDescending(x => x.ProductInventory).ToList()
                };
            }
            else
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 400,
                    Success = false,
                    Message = "传递参数为'up'or'down'"
                };
            }

        }
        #endregion

        [HttpGet("GetAllLimitProduct")]
        public async Task<MessageModel<List<Product>>> GetAllLimitProduct(int skip,int take)
        {
            var entities = await _productService.GetLimitProductAsync(skip, take);
            return new MessageModel<List<Product>>
            {
                Status = 200,
                Success = true,
                Data = entities
            };
        }

        [HttpGet("GetListProductByCategoryName")]
        public async Task<MessageModel<List<Product>>> GetListProductByCategoryName(string categoryName)
        {
            var entity = await _categoryService.GetCategoryAsync(c => c.CategoryName == categoryName);
            if (entity == null)
            {
                return new MessageModel<List<Product>>()
                {
                    Status = 404,
                    Success = false,
                    Message = "该类别不存在"
                };
            }
            var products = await _productService.GetListProductAsync(p => p.ProductCategory == categoryName);
            return new MessageModel<List<Product>>()
            {
                Status = 200,
                Success = true,
                Data = products
            };
        }

        [HttpGet("GetProductById")]
        public async Task<Product> GetProductById(Guid id)
        {
            return await _productService.FindProductAsync(x => x.Id == id);
        }

        [HttpGet("GetProductByProductName")]
        public async Task<List<Product>> GetProductByName(string name)
        {
            return await _productService.GetListProductAsync(x => x.ProductName == name);
        }



        //轮播图
        [HttpPost("InsertCarousel")]
        public async Task<MessageModel<string>> InsertCarousel(Carousel carousel)
        {
            var entity = await _productService.FindCarouselAsync(x => x.ProductId == carousel.ProductId);
            if(entity != null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "该产品已存在轮播图中"
                };
            }
            await _productService.InsertCarouselAync(carousel);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = false,
                Message = "增加成功"
            };
        }
        [HttpDelete("DeleteAllCarousel")]
        public async Task DeleteAllCarousel()
        {
            await _productService.DeleteAllCarouselAsync();
        }
        [HttpDelete("DeleteCarouselById")]
        public async Task<MessageModel<string>> DeleteCarouselById(Guid id)
        {
            var entity = await _productService.FindCarouselAsync(x => x.ProductId == id);
            if(entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "该产品不存在轮播图中"
                };
            }
            await _productService.DeleteCarouselAsync(entity);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "移除成功"
            };
        }
        [HttpGet("GetAllCarousel")]
        public async Task<List<Product>> GetAllCarousel()
        {
            var carousels = await _productService.GetAllCarouselAsync();
            List<Product> products = new();
            foreach(var carousel in carousels)
            {
                products.Add(await _productService.FindProductAsync(x => x.Id == carousel.ProductId));
            }
            return products;
        }

    }
}
