using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Shopping.ShoppingEntity.Entity;
using Shopping.ShoppingEntity.IRepository.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ShoppingDbContext _ShoppingDbContext;

        public BaseRepository(ShoppingDbContext shoppingDbContext)
        {
            _ShoppingDbContext = shoppingDbContext;
        }

        public async Task DeleteAllAsync()
        {
            await _ShoppingDbContext.Set<TEntity>().ExecuteDeleteAsync();
            await _ShoppingDbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _ShoppingDbContext.Set<TEntity>().Remove(entity);
            await _ShoppingDbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Expression<Func<TEntity, bool>> exp)
        {
            var entity = await FindAsync(exp);
            _ShoppingDbContext.Set<TEntity>().Remove(entity);
            await _ShoppingDbContext.SaveChangesAsync();
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> exp)
        {
            return await _ShoppingDbContext.Set<TEntity>().Where(exp).SingleOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> exp)
        {
            return await _ShoppingDbContext.Set<TEntity>().Where(exp).ToListAsync();
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _ShoppingDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _ShoppingDbContext.Set<TEntity>().AddAsync(entity);
            await _ShoppingDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _ShoppingDbContext.Set<TEntity>().Update(entity);
            await _ShoppingDbContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetLimitAsync(Expression<Func<TEntity, bool>> exp, int skip, int take)
        {
            return await _ShoppingDbContext.Set<TEntity>().Where(exp).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<List<TEntity>> GetLimitAsync(int skip, int take)
        {
            return await _ShoppingDbContext.Set<TEntity>().Skip(skip).Take(take).ToListAsync();
        }
        public async Task<int> UpdateAsync(Expression<Func<TEntity, bool>> exp, Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls)
        {
            int num = await _ShoppingDbContext.Set<TEntity>().Where(exp).ExecuteUpdateAsync(setPropertyCalls);
            await _ShoppingDbContext.SaveChangesAsync();
            return num;
        }

    }
}
