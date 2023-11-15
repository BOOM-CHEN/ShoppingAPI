using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ShoppingDbContext _shoppingDbContext;
        private readonly IBaseRepository<User> _baseRepository;
        public UserRepository(ShoppingDbContext shoppingDbContext, IBaseRepository<User> baseRepository) : base(shoppingDbContext)
        {
            _shoppingDbContext = shoppingDbContext;
            _baseRepository = baseRepository;
        }

        public async Task DeleteAllUserAsync()
        {
            await _baseRepository.DeleteAllAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            await _baseRepository.DeleteAsync(user);
        }

        public async Task DeleteUserAsync(Expression<Func<User, bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }
        public async Task<List<User>> GetAllUserAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _baseRepository.FindAsync(f => f.UserEmail == email);
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _baseRepository.FindAsync(f => f.Id == id);
        }
        public async Task<User> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            return await _baseRepository.FindAsync(f => f.UserPhoneNumber == phoneNumber);
        }

        public async Task InsertUserAsync(User user)
        {
            await _baseRepository.InsertAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _baseRepository.UpdateAsync(user);
        }

        public async Task<List<User>> GetListUserAsync(Expression<Func<User, bool>> exp)
        {
            return await _baseRepository.GetListAsync(exp);
        }

        public async Task<Password> FindPasswordAsync(Expression<Func<Password, bool>> exp)
        {
            return await _shoppingDbContext.Set<Password>().Where(exp).SingleOrDefaultAsync();
        }
        public async Task<List<User>> GetLimitUserAsync(int skip,int take)
        {
            return await _shoppingDbContext.Set<User>().OrderBy(x=>x.RegisterTime).Skip(skip).Take(take).ToListAsync();
        }
        public async Task<List<User>> GetLimitUserAsync(Expression<Func<User,bool>> exp,int skip,int take)
        {
            return await _shoppingDbContext.Set<User>().Where(exp).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<int> GetUserTotalAsync()
        {
            return await _shoppingDbContext.Set<User>().CountAsync();
        }
        public async Task<int> GetUserTotalAsync(Expression<Func<User,bool>> exp)
        {
            return await _shoppingDbContext.Set<User>().Where(exp).CountAsync();
        }

        public async Task<int> UpdateUserAsync(Expression<Func<User, bool>> exp, Expression<Func<SetPropertyCalls<User>, SetPropertyCalls<User>>> setPropertyCalls)
        {
            return await _baseRepository.UpdateAsync(exp, setPropertyCalls);
        }

        public async Task<int> UpdatePasswordAsync(Expression<Func<Password, bool>> exp, Expression<Func<SetPropertyCalls<Password>, SetPropertyCalls<Password>>> setPropertyCalls)
        {
            return await _shoppingDbContext.Set<Password>().Where(exp).ExecuteUpdateAsync(setPropertyCalls);
        }

    }
}
