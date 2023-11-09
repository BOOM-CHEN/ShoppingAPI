using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.IRepository
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        public Task InsertCategoryAsync(Category category);
        public Task DeleteCategoryAsync(Expression<Func<Category,bool>> exp);
        public Task<Category> GetCategoryAsync(Expression<Func<Category, bool>> exp);
        public Task<List<Category>> GetAllCategoryAsync();
    }
}
