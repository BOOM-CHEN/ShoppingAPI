using Shopping.ShoppingAPI.Utils.Swagger;

namespace Shopping.ShoppingAPI.Utils.SwaggerExt
{
    public static class CustomSwaggerExt
    {
        public static void AddBuilderServicesExt(this IServiceCollection services)
        {
            //swaggerConfiger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(opt =>
            {
                var file = Path.Combine(AppContext.BaseDirectory, "Shopping.ShoppingAPI.xml");
                opt.IncludeXmlComments(file, true);//显示注释
                opt.OrderActionsBy(o => o.HttpMethod);//排序
                opt.SchemaFilter<DefaultValueSchemaFilter>();
            });
        }
        public static void AddAppExt(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
