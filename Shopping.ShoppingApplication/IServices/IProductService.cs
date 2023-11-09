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
    public interface IProductService : IBaseServices<Product>
    {
        public Task<List<Product>> GetAllProductAsync();
        public Task<Product> FindProductAsync(Expression<Func<Product, bool>> exp);
        public Task<List<Product>> GetListProductAsync(Expression<Func<Product, bool>> exp);
        public Task InsertProductAsync(Product product);
        public Task DeleteAllProductAsync();
        public Task DeleteProductAsync(Expression<Func<Product, bool>> exp);
        public Task UpdateProductAsync(Product product);
        public Task<List<Product>> GetLimitProductAsync(Expression<Func<Product, bool>> exp, int skip, int take);
        public Task<List<Product>> GetLimitProductAsync(int skip, int take);

        //ProductCategory
        public Task InsertProductCategoryAsync(ProductCategory productCategory);

        //轮播图
        public Task InsertCarouselAync(Carousel carousel);
        public Task DeleteAllCarouselAsync();
        public Task DeleteCarouselAsync(Expression<Func<Carousel, bool>> exp);
        public Task DeleteCarouselAsync(Carousel carousel);
        public Task<List<Carousel>> GetAllCarouselAsync();
        public Task<Carousel> FindCarouselAsync(Expression<Func<Carousel, bool>> exp);
    }
}
