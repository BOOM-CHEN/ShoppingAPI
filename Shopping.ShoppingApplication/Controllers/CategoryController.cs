using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingEntity.Dto.CategoryDto;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpPost("AddCategory")]
        public async Task<MessageModel<string>> AddCategory(Category category)
        {
            var entity = await _categoryService.GetCategoryAsync(x => x.CategoryName == category.CategoryName);
            if(entity != null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "该类别已存在"
                };
            }
            await _categoryService.InsertAsync(category);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "添加成功"
            };
        }

        [HttpDelete("DeleteCategoryByName")]
        public async Task<MessageModel<string>> DeleteCategoryByName(string categoryName)
        {
            var entity = await _categoryService.GetCategoryAsync(x =>x.CategoryName == categoryName);
            if(entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = $"名为{categoryName}的类别不存在"
                };
            }
            await _categoryService.DeleteCategoryAsync(x =>x.CategoryName == categoryName);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }

        [HttpGet("GetCategoryByName")]
        public async Task<MessageModel<Category>> GetCategoryByName(string categoryName)
        {
            var entity = await _categoryService.GetCategoryAsync(x => x.CategoryName == categoryName);
            if (entity == null)
            {
                return new MessageModel<Category>()
                {
                    Status = 400,
                    Success = false,
                    Message = $"名为{categoryName}的类别不存在"
                };
            }
            return new MessageModel<Category>()
            {
                Status = 200,
                Success = true,
                Data = entity
            };
        }

        [HttpGet("GetAllCategory")]
        public async Task<MessageModel<List<CategoryNameDto>>> GetAllCategoriy()
        {
            var entity = await _categoryService.GetAllCategoryAsync();
            List<CategoryNameDto> categoryNameDtos = new();
            foreach(var category in entity)
            {
                categoryNameDtos.Add(_mapper.Map<CategoryNameDto>(category));
            }
            
            return new MessageModel<List<CategoryNameDto>>()
            {
                Status = 200,
                Success = true,
                Data = categoryNameDtos
            };
        }
    }
}
