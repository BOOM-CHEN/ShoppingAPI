using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.IRepository.IBase
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> FindAsync(Expression<Func<TEntity,bool>> exp);
        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> exp);
        public Task<List<TEntity>> GetAllAsync();
        public Task InsertAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        Task<int> UpdateAsync(Expression<Func<TEntity, bool>> exp, Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls);
        public Task DeleteAsync(Expression<Func<TEntity, bool>> exp);
        public Task DeleteAllAsync();
        public Task DeleteAsync(TEntity entity);
        public Task<List<TEntity>> GetLimitAsync(Expression<Func<TEntity, bool>> exp,int skip,int take);
        public Task<List<TEntity>> GetLimitAsync(int skip, int take);
    }
}
