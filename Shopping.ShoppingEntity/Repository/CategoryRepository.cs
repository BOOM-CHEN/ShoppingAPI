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
    public class CategoryRepistory : BaseRepository<Category>, ICategoryRepository
    {
        private readonly IBaseRepository<Category> _baseRepository;
        public CategoryRepistory(ShoppingDbContext shoppingDbContext,IBaseRepository<Category> baseRepository) : base(shoppingDbContext)
        {
            _baseRepository = baseRepository;
        }

        public async Task DeleteCategoryAsync(Expression<Func<Category, bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryAsync(Expression<Func<Category, bool>> exp)
        {
            return await _baseRepository.FindAsync(exp);
        }

        public async Task InsertCategoryAsync(Category category)
        {
            await _baseRepository.InsertAsync(category);
        }
    }
}
