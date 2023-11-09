using Microsoft.EntityFrameworkCore.Query;
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
    public class UserService : BaseServices<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IBaseRepository<User> baseRepository, IUserRepository userRepository) : base(baseRepository)
        {
            _userRepository = userRepository;
        }

        public async Task DeleteAllUserAsync()
        {
            await _userRepository.DeleteAllUserAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            await _userRepository.DeleteUserAsync(user);
        }

        public async Task DeleteUserAsync(Expression<Func<User, bool>> exp)
        {
            await _userRepository.DeleteUserAsync(exp);
        }

        public async Task<Password> FindPasswordAsync(Expression<Func<Password, bool>> exp)
        {
            return await _userRepository.FindPasswordAsync(exp);
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await _userRepository.GetAllUserAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetUserByEmailAsync(email);
        }
        public async Task<User> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            return await _userRepository.GetUserByPhoneNumberAsync(phoneNumber);
        }
        public async Task<List<User>> GetListUserAsync(Expression<Func<User, bool>> exp)
        {
            return await _userRepository.GetListUserAsync(exp);
        }
        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task InsertUserAsync(User user)
        {
            await _userRepository.InsertUserAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task<List<User>> GetLimitUserAsync(int skip, int take)
        {
            return await _userRepository.GetLimitUserAsync(skip, take);
        }
        public async Task<List<User>> GetLimitUserAsync(Expression<Func<User, bool>> exp, int skip, int take)
        {
            return await _userRepository.GetLimitUserAsync(exp, skip, take);
        }
        public Task<int> GetUserTotalAsync()
        {
            return _userRepository.GetUserTotalAsync();
        }
        public async Task<int> GetUserTotalAsync(Expression<Func<User, bool>> exp)
        {
            return await _userRepository.GetUserTotalAsync(exp);
        }
        public async Task<int> UpdateUserAsync(Expression<Func<User, bool>> exp, Expression<Func<SetPropertyCalls<User>, SetPropertyCalls<User>>> setPropertyCalls)
        {
            return await _userRepository.UpdateUserAsync(exp, setPropertyCalls);
        }
        public async Task<int> UpdatePasswordAsync(Expression<Func<Password, bool>> exp, Expression<Func<SetPropertyCalls<Password>, SetPropertyCalls<Password>>> setPropertyCalls)
        {
            return await _userRepository.UpdatePasswordAsync(exp, setPropertyCalls);
        }
    }
}
