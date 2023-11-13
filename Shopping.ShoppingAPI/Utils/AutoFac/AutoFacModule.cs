using Autofac;
using Shopping.ShoppingApplication.IServers.IBase;
using Shopping.ShoppingApplication.IServices;
using Shopping.ShoppingApplication.Services;
using Shopping.ShoppingApplication.Services.Base;
using Shopping.ShoppingEntity.IRepository;
using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Repository;
using Shopping.ShoppingEntity.Repository.Base;

namespace Shopping.ShoppingAPI.Utils.AutoFac
{
    /// <summary>
    /// 自动注册
    /// </summary>
    public class AutoFacModule : Autofac.Module
    {
        /// <summary>
        /// auto
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            //Repository
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerDependency();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerDependency();
            builder.RegisterType<CartRepository>().As<ICartRepository>().InstancePerDependency();
            builder.RegisterType<CategoryRepistory>().As<ICategoryRepository>().InstancePerDependency();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerDependency();
            //Services
            builder.RegisterGeneric(typeof(BaseServices<>)).As(typeof(IBaseServices<>)).InstancePerDependency();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerDependency();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerDependency();
            builder.RegisterType<CartService>().As<ICartService>().InstancePerDependency();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerDependency();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerDependency();
        }
    }
}
