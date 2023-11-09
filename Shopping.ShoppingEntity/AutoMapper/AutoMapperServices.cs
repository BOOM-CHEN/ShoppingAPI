using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.AutoMapper
{
    public static class AutoMapperServices
    {
        public static void AddAutoMapperServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfigs));
        }
    }
}
