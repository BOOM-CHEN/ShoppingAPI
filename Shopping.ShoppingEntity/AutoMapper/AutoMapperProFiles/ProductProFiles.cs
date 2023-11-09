using AutoMapper;
using Shopping.ShoppingEntity.Dto.ProductDto;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.AutoMapper.AutoMapperProFiles
{
    public class ProductProFiles : Profile
    {
        public ProductProFiles()
        {
            CreateMap<ProductAddDto, Product>();
        }
    }
}
