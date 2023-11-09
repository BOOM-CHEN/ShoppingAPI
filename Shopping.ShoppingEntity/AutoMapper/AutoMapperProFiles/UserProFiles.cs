using AutoMapper;
using Shopping.ShoppingEntity.Dto.UserDto;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.AutoMapper.AutoMapperProFiles
{
    public class UserProFiles : Profile
    {
        public UserProFiles()
        {
            CreateMap<UserRegisterDto, User>();
            CreateMap<User, UserLoginDto>();
            CreateMap<User, UserInfoDto>();
        }
    }
}
