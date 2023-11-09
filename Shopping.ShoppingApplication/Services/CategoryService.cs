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
    public class CategoryService : BaseServices<Category> , ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IBaseRepository<Category> baseRepository , ICategoryRepository categoryRepository) : base(baseRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task DeleteCategoryAsync(Expression<Func<Category, bool>> exp)
        {
            await _categoryRepository.DeleteCategoryAsync(exp);
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            return await _categoryRepository.GetAllCategoryAsync();
        }

        public async Task<Category> GetCategoryAsync(Expression<Func<Category, bool>> exp)
        {
            return await _categoryRepository.GetCategoryAsync(exp);
        }

        public async Task InsertCategoryAsync(Category category)
        {
            await _categoryRepository.InsertCategoryAsync(category);
        }
    }
}
