using AutoMapper;
using Shopping.ShoppingEntity.Dto.CategoryDto;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.AutoMapper.AutoMapperProFiles
{
    public class CategoryProFiles : Profile
    {
        public CategoryProFiles()
        {
            CreateMap<Category,CategoryNameDto>();
        }
    }
}
