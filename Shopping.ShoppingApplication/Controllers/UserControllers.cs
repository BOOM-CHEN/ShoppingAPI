using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingApplication.Utils.Email;
using Shopping.ShoppingApplication.Utils.JWT;
using Shopping.ShoppingApplication.Utils.Password;
using Shopping.ShoppingEntity.Dto.UserDto;
using Shopping.ShoppingEntity.Models;

namespace Shopping.ShoppingAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserControllers : ControllerBase
    {
        private readonly IDistributedCache _distributedCache;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly ILogger<UserControllers> _logger;
        public UserControllers(IUserService userService, IMapper mapper,IDistributedCache distributedCache, ILogger<UserControllers> logger)
        {
            _userService = userService;
            _mapper = mapper;
            _distributedCache = distributedCache;
            _logger = logger;
        }

        #region Get
        /// <summary>
        /// 获取所有用户分页,root
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [Authorize(Roles = ("root"))]
        [HttpGet("GetLimitUser")]
        public async Task<MessageModel<List<UserInfoDto>>> GetLimiteUser(int skip, int take)
        {
            var users = await _distributedCache.GetStringAsync("GetLimitUser" + skip + take);
            if (users == null)
            {
                var entity = await _userService.GetLimitUserAsync(skip, take);
                List<UserInfoDto> user = new();
                foreach (var item in entity)
                {
                    user.Add(_mapper.Map<UserInfoDto>(item));
                }
                await _distributedCache.SetStringAsync("GetLimitUser" + skip + take,JsonConvert.SerializeObject(user),new DistributedCacheEntryOptions() { AbsoluteExpiration = DateTimeOffset.Now.AddDays(1),SlidingExpiration = TimeSpan.FromHours(new Random().NextDouble()*24)});
                users = await _distributedCache.GetStringAsync("GetLimitUser" + skip + take);
            }
            return new MessageModel<List<UserInfoDto>>()
            {
                Status = 200,
                Success = true,
                Data = JsonConvert.DeserializeObject<List<UserInfoDto>>(users)
            };
        }
        [Authorize(Roles = ("root"))]
        [HttpGet("GetAllUserTotal")]
        public async Task<MessageModel<int>> GetAllUserTotal()
        {
            int total = await _userService.GetUserTotalAsync();
            return new MessageModel<int>()
            {
                Status = 200,
                Success = true,
                Data = total
            };
        }//获取所有用户的数量

        [HttpGet("GetAllLimitroot")]
        [Authorize(Roles = ("root"))]
        public async Task<MessageModel<List<UserInfoDto>>> GetAllLimitroot(int skip, int take)
        {
            var entity = await _userService.GetLimitUserAsync(x => x.Role == "root", skip, take);
            List<UserInfoDto> user = new();
            foreach (var item in entity)
            {
                user.Add(_mapper.Map<UserInfoDto>(item));
            }
            return new MessageModel<List<UserInfoDto>>()
            {
                Status = 200,
                Success = true,
                Data = user
            };
        }
        [Authorize(Roles = ("root"))]
        [HttpGet("GetrootTotal")]
        public async Task<MessageModel<int>> GetrootTotal()
        {
            int total = await _userService.GetUserTotalAsync(x => x.Role == "root");
            return new MessageModel<int>()
            {
                Status = 200,
                Success = true,
                Data = total
            };
        }//获取root用户的数量

        [HttpGet("GetAllLimitadmin")]
        [Authorize(Roles = ("root"))]
        public async Task<MessageModel<List<UserInfoDto>>> GetAllLimitadmin(int skip, int take)
        {
            var entity = await _userService.GetLimitUserAsync(x => x.Role == "admin", skip, take);
            List<UserInfoDto> user = new();
            foreach (var item in entity)
            {
                user.Add(_mapper.Map<UserInfoDto>(item));
            }
            return new MessageModel<List<UserInfoDto>>()
            {
                Status = 200,
                Success = true,
                Data = user
            };
        }
        [Authorize(Roles = ("root"))]
        [HttpGet("GetadminTotal")]
        public async Task<MessageModel<int>> GetadminTotal()
        {
            int total = await _userService.GetUserTotalAsync(x => x.Role == "admin");
            return new MessageModel<int>()
            {
                Status = 200,
                Success = true,
                Data = total
            };
        }//获取admin用户的数量

        [HttpGet("GetAllLimituser")]
        [Authorize(Roles = ("admin,root"))]
        public async Task<MessageModel<List<UserInfoDto>>> GetAllLimituser(int skip, int take)
        {
            var entity = await _userService.GetLimitUserAsync(x => x.Role == "user", skip, take);
            List<UserInfoDto> user = new();
            foreach (var item in entity)
            {
                user.Add(_mapper.Map<UserInfoDto>(item));
            }
            return new MessageModel<List<UserInfoDto>>()
            {
                Status = 200,
                Success = true,
                Data = user
            };
        }
        [Authorize(Roles = ("root,admin"))]
        [HttpGet("GetuserTotal")]
        public async Task<MessageModel<int>> GetuserTotal()
        {
            int total = await _userService.GetUserTotalAsync(x => x.Role == "user");
            return new MessageModel<int>()
            {
                Status = 200,
                Success = true,
                Data = total
            };
        }//获取user用户的数量

        //[Authorize(Roles = ("root"))]
        [HttpGet("GetAllUsers")]
        public async Task<MessageModel<List<UserInfoDto>>> GetAllUsers()
        {
            var entity = await _userService.GetAllUserAsync();
            List<UserInfoDto> user = new();
            foreach (var item in entity)
            {
                user.Add(_mapper.Map<UserInfoDto>(item));
            }
            return new MessageModel<List<UserInfoDto>>()
            {
                Status = 200,
                Success = true,
                Data = user
            };
        }//获取所有用户不分页

        [HttpPost("GetUserById")]
        public async Task<MessageModel<User>> GetUserById(Guid id)
        {
            var cacheUser = await _distributedCache.GetStringAsync("UserId"+id);
            if (cacheUser == null)
            {
                User user = await _userService.GetUserByIdAsync(id);
                if (user == null)
                {
                    //防止缓存穿透
                    await _distributedCache.SetStringAsync("UserId" + id,
                        "UserId" + id,
                        new DistributedCacheEntryOptions() { 
                            AbsoluteExpiration = DateTime.Now.AddHours(1),
                            SlidingExpiration = TimeSpan.FromMinutes(10)
                        });
                    cacheUser = await _distributedCache.GetStringAsync("UserId" + id);
                }
                else
                {
                    await _distributedCache.SetStringAsync("UserId" + id,
                        JsonConvert.SerializeObject(user),
                        new DistributedCacheEntryOptions()
                        {
                            AbsoluteExpiration = DateTime.Now.AddHours(1),
                            SlidingExpiration = TimeSpan.FromMinutes(10)
                        });
                    cacheUser = await _distributedCache.GetStringAsync("UserId" + id);
                }
            }
            if (cacheUser == "UserId" + id)
            {
                return new MessageModel<User>()
                {
                    Status = 400,
                    Success = false,
                    Message = "未找到该用户",
                };
            }
            return new MessageModel<User>()
            {
                Status = 200,
                Success = true,
                Message = "查询成功",
                Data = JsonConvert.DeserializeObject<User>(cacheUser)
            };
        }

        [HttpGet("GetUserByEmail")]
        public async Task<MessageModel<UserInfoDto>> GetUserByEmail(string email)
        {
            var entity = await _userService.GetUserByEmailAsync(email);
            var user = _mapper.Map<UserInfoDto>(entity);
            return new MessageModel<UserInfoDto>()
            {
                Status = 200,
                Success = true,
                Data = user
            };
        }
        #endregion


        [Authorize(Roles = ("root"))]
        [HttpDelete("DeleteAllUser")]
        public async Task DeleteAllUser()
        {
            await _userService.DeleteAllUserAsync();
        }

        [HttpDelete("DeleteUserById")]
        public async Task<MessageModel<string>> DeleteUserById(Guid id)
        {
            var entity = await _userService.FindAsync(x=>x.Id == id);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 404,
                    Success = false,
                    Message = $"id为{id}的用户不存在"
                };
            }
            await _userService.DeleteUserAsync(entity);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }

        [Authorize(Roles = ("root,admin"))]
        [HttpDelete("DeleteUserByEmail")]
        public async Task<MessageModel<string>> DeleteUserByEmail(string email)
        {
            var entity = await _userService.GetUserByEmailAsync(email);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "未找到该用户"
                };
            }
            await _userService.DeleteUserAsync(x => x.UserEmail == email);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "删除成功"
            };
        }


        [Authorize(Roles = ("root,admin"))]//注册
        [HttpPost("InsertUser")]
        public async Task<MessageModel<string>> InsertUser(UserRegisterDto userRegisterDto)
        {
            if (!EmailConfirm.ConfirmEmail(userRegisterDto.UserEmail))
            {
                return new MessageModel<string>
                {
                    Status = 400,
                    Message = "请输入正确的邮箱",
                    Success = false
                };
            }
            var entity = await _userService.FindAsync(x => x.UserEmail == userRegisterDto.UserEmail);
            if (entity != null)
            {
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "用户已被注册",
                    Success = false
                };
            }
            else
            {
                //数据库不存在该用户
                var user = _mapper.Map<User>(userRegisterDto);
                ///AES加密
                byte[] cipherText = PasswordAES.Encrypt(userRegisterDto.UserPassword, out byte[] PublicKey, out byte[] IV);
                user.UserPassword = Convert.ToBase64String(cipherText);
                user.RegisterTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                user.Passwords = new()
                {
                    Id = new Guid(),
                    UserId = user.Id,
                    PublicKey = Convert.ToBase64String(PublicKey),
                    IV = Convert.ToBase64String(IV)
                };
                await _userService.InsertUserAsync(user);
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "注册成功!",
                    Success = true,
                };
            }
        }

        [HttpPut("UpdateUser")]
        public async Task<MessageModel<string>> UpdateUser(userUserUpdateDto userUserUpdateDto)
        {
            var entity = await _userService.GetUserByEmailAsync(userUserUpdateDto.UserEmail);
            if (entity == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "未找到更新对象"
                };
            }
            await _userService.UpdateUserAsync(entity);
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "更新成功"
            };
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userLoginDto"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<MessageModel<string>> Login(UserLoginDto userLoginDto)
        {
            var entity = await _userService.FindAsync(x => x.UserEmail == userLoginDto.UserEmail);
            if (entity == null)
            {
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "邮箱或密码错误",
                    Success = false
                };
            }
            if(entity.Role == "user")
            {
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "你无权登录",
                    Success = false
                };
            }
            var password = await _userService.FindPasswordAsync(e => e.UserId == entity.Id);
            if (userLoginDto.UserPassword == PasswordAES.Decrypt(Convert.FromBase64String(entity.UserPassword)
                , Convert.FromBase64String(password.PublicKey)
                , Convert.FromBase64String(password.IV)))
            {
                //token过期
                if (!JwtHelper.ValidateToken(entity.Token))
                {
                    entity.Token = JwtHelper.CreateJwt(entity.Role, entity.UserName, entity.UserEmail);
                    await _userService.UpdateUserAsync(entity);
                }
                return new MessageModel<string>
                {
                    Status = 200,
                    Success = true,
                    Message = "登录成功",
                    Data = entity.Token
                };
            }
            else
            {
                return new MessageModel<string>
                {
                    Status = 200,
                    Success = false,
                    Message = "邮箱或密码错误",
                };
            }
        }


        //前端

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("customerRegister")]
        //注册普通用户
        public async Task<MessageModel<string>> customerRegitser(UserRegisterDto userRegisterDto)
        {
            if (!EmailConfirm.ConfirmEmail(userRegisterDto.UserEmail))
            {
                return new MessageModel<string>
                {
                    Status = 400,
                    Message = "请输入正确的邮箱",
                    Success = false
                };
            }
            var entity = await _userService.FindAsync(x => x.UserEmail == userRegisterDto.UserEmail);
            if (entity != null)
            {
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "用户已被注册",
                    Success = false
                };
            }
            else
            {
                //数据库不存在该用户
                var user = _mapper.Map<User>(userRegisterDto);
                ///AES加密
                byte[] cipherText = PasswordAES.Encrypt(userRegisterDto.UserPassword, out byte[] PublicKey, out byte[] IV);
                user.Role = "user";
                user.UserPassword = Convert.ToBase64String(cipherText);
                user.RegisterTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                user.Passwords = new()
                {
                    Id = new Guid(),
                    UserId = user.Id,
                    PublicKey = Convert.ToBase64String(PublicKey),
                    IV = Convert.ToBase64String(IV)
                };
                await _userService.InsertUserAsync(user);
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "注册成功!",
                    Success = true,
                };
            }
        }

        [HttpPost("customerLogin")]
        public async Task<MessageModel<string>> customerLogin(UserLoginDto userLoginDto)
        {
            var entity = await _userService.FindAsync(x => x.UserEmail == userLoginDto.UserEmail);
            if (entity == null)
            {
                _logger.LogInformation(userLoginDto.UserEmail + $" is fail login on {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                return new MessageModel<string>
                {
                    Status = 200,
                    Message = "邮箱或密码错误",
                    Success = false
                };
            }
            
            var password = await _userService.FindPasswordAsync(e => e.UserId == entity.Id);
            if (userLoginDto.UserPassword == PasswordAES.Decrypt(Convert.FromBase64String(entity.UserPassword)
                , Convert.FromBase64String(password.PublicKey)
                , Convert.FromBase64String(password.IV)))
            {
                //先从redis中获取token
                var RedisValueJson = await _distributedCache.GetStringAsync(userLoginDto.UserEmail + "token");
                //判断是否存在token
                if (string.IsNullOrEmpty(RedisValueJson))
                {
                    //不存在则重新生成一份token,并生成一份缓存
                    //token过期
                    if (!JwtHelper.ValidateToken(entity.Token))
                    {
                        entity.Token = JwtHelper.CreateJwt(entity.Role, entity.UserName, entity.UserEmail);
                        await _userService.UpdateUserAsync(entity);
                    }
                    await _distributedCache.SetStringAsync(userLoginDto.UserEmail + "token", entity.Token
                        ,new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromHours(new Random().NextDouble()*24)).SetAbsoluteExpiration(DateTimeOffset.Now.AddDays(1)));
                    RedisValueJson = await _distributedCache.GetStringAsync(userLoginDto.UserEmail + "token");
                }
                return new MessageModel<string>
                {
                    Status = 200,
                    Success = true,
                    Message = "登录成功",
                    Data = RedisValueJson
                };
            }
            else
            {
                _logger.LogInformation(userLoginDto.UserEmail + $" is fail login on {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                return new MessageModel<string>
                {
                    Status = 200,
                    Success = false,
                    Message = "邮箱或密码错误",
                };
            }
        }

        [HttpPost("Upload")]
        public async Task<MessageModel<string>> Upload(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return new MessageModel<string>()
                    {
                        Status = 400,
                        Success = false,
                    };
                }
                    
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "avatar", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return new MessageModel<string>()
                {
                    Status = 200,
                    Success = true,
                };
            }
            catch (Exception ex)
            {
                return new MessageModel<string>()
                {
                    Status = 500,
                    Success = false,
                    Message = ex.Message,
                };
            }
        }

        [HttpPut("UpdateUserUser")]
        public async Task<MessageModel<string>> UpdateUserUser(userUserUpdateDto userUserUpdateDto)
        {
            var user = await _userService.GetUserByIdAsync(userUserUpdateDto.Id);
            if(user == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "用户不存在"
                };
            }

            //判断唯一键
            var isExit = await _userService.GetUserByEmailAsync(userUserUpdateDto.UserEmail);
            if(isExit != null && user.UserEmail != userUserUpdateDto.UserEmail)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "修改的邮箱已被注册"
                };
            }
            if (userUserUpdateDto.UserPhoneNumber != null && user.UserEmail != userUserUpdateDto.UserEmail)
            {
                var isConflict = await _userService.GetUserByPhoneNumberAsync(userUserUpdateDto.UserPhoneNumber);
                if (isConflict != null)
                {
                    return new MessageModel<string>()
                    {
                        Status = 400,
                        Success = false,
                        Message = "修改的电话已被绑定"
                    };
                }
            }
            

            var num = await _userService.UpdateUserAsync(u => u.Id == userUserUpdateDto.Id,
                s => s.SetProperty(p => p.UserName,userUserUpdateDto.UserName == "" ? user.UserName : userUserUpdateDto.UserName)
                      .SetProperty(p => p.UserEmail,userUserUpdateDto.UserEmail == "" ? user.UserEmail : userUserUpdateDto.UserEmail)
                      .SetProperty(p => p.UserPhoneNumber,userUserUpdateDto.UserPhoneNumber == "" ? user.UserPhoneNumber : userUserUpdateDto.UserPhoneNumber)
                      .SetProperty(p => p.UserRecieveAddress,userUserUpdateDto.UserRecieveAddress == "" ? user.UserRecieveAddress : userUserUpdateDto.UserRecieveAddress));
            if(num <= 0)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "请输入要更新的值"
                };
            }

            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "更新成功"
            };
        }
        [HttpPut("UpdateUserPassword")]
        public async Task<MessageModel<string>> UpdateUserPassword(Guid id, string password)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = $"用户不存在"
                };
            }
            if(password == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "密码未改变"
                };
            }
            byte[] cipherText = PasswordAES.Encrypt(password, out byte[] publicKey, out byte[] IV);
            await _userService.UpdateUserAsync(u => u.Id == id,
                s => s.SetProperty(p => p.UserPassword,Convert.ToBase64String(cipherText)));
            var Password = await _userService.FindPasswordAsync(x => x.UserId == user.Id);
            await _userService.UpdatePasswordAsync(pw => pw.Id == Password.Id,
                s => s.SetProperty(p => p.PublicKey,Convert.ToBase64String(publicKey))
                      .SetProperty(p => p.IV,Convert.ToBase64String(IV)));
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "修改成功"
            };
        }
        [HttpPut("UpdateUserRole")]
        [Authorize(Roles = "root")]
        public async Task<MessageModel<string>> UpdateUserRole(Guid id,string role)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = $"用户不存在"
                };
            }
            if(role == null || role == user.Role)
            {
                return new MessageModel<string>()
                {
                    Status = 400,
                    Success = false,
                    Message = "用户级别未改变"
                };
            }
            await _userService.UpdateUserAsync(e => e.Id == id,
                s => s.SetProperty(p => p.Role,role));
            return new MessageModel<string>()
            {
                Status = 200,
                Success = true,
                Message = "更新成功"
            };
        }
    }
}
