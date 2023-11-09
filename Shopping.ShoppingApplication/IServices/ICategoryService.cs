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
    public interface ICategoryService : IBaseServices<Category>
    {
        public Task InsertCategoryAsync(Category category);
        public Task DeleteCategoryAsync(Expression<Func<Category, bool>> exp);
        public Task<Category> GetCategoryAsync(Expression<Func<Category, bool>> exp);
        public Task<List<Category>> GetAllCategoryAsync();
    }
}
