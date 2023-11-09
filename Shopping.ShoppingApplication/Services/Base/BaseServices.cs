using Microsoft.EntityFrameworkCore.Query;
using Shopping.ShoppingApplication.IServers.IBase;
using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingApplication.Services.Base
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        public BaseServices(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task DeleteAllAsync()
        {
            await _baseRepository.DeleteAllAsync();
        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _baseRepository.DeleteAsync(entity);
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> exp)
        {
            return await _baseRepository.FindAsync(exp);
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> exp)
        {
            return _baseRepository.GetListAsync(exp);
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _baseRepository.InsertAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _baseRepository.UpdateAsync(entity);
        }
        public async Task<int> UpdateAsync(Expression<Func<TEntity, bool>> exp, Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls)
        {
            return await _baseRepository.UpdateAsync(exp, setPropertyCalls);
        }
    }
}
