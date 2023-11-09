using Microsoft.EntityFrameworkCore.Query;
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
    public interface IUserService : IBaseServices<User>
    {
        public Task<User> GetUserByIdAsync(Guid id);
        public Task<List<User>> GetListUserAsync(Expression<Func<User, bool>> exp);
        public Task<List<User>> GetAllUserAsync();
        public Task<User> GetUserByEmailAsync(string email);
        public Task<User> GetUserByPhoneNumberAsync(string phoneNumber);
        public Task DeleteAllUserAsync();
        public Task DeleteUserAsync(User user);
        public Task DeleteUserAsync(Expression<Func<User, bool>> exp);
        public Task InsertUserAsync(User user);
        public Task UpdateUserAsync(User user);
        public Task<int> UpdateUserAsync(Expression<Func<User, bool>> exp, Expression<Func<SetPropertyCalls<User>, SetPropertyCalls<User>>> setPropertyCalls);
        public Task<Password> FindPasswordAsync(Expression<Func<Password, bool>> exp);
        public Task<int> UpdatePasswordAsync(Expression<Func<Password, bool>> exp, Expression<Func<SetPropertyCalls<Password>, SetPropertyCalls<Password>>> setPropertyCalls);
        public Task<List<User>> GetLimitUserAsync(int skip, int take);
        public Task<List<User>> GetLimitUserAsync(Expression<Func<User, bool>> exp, int skip, int take);
        public Task<int> GetUserTotalAsync();
        public Task<int> GetUserTotalAsync(Expression<Func<User, bool>> exp);
    }
}
