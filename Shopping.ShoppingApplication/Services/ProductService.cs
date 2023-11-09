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
    public class ProductService : BaseServices<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IBaseRepository<Product> baseRepository,IProductRepository productRepository) : base(baseRepository)
        {
            _productRepository = productRepository;
        }

        public async Task DeleteAllProductAsync()
        {
            await _productRepository.DeleteAllAsync();
        }

        public async Task DeleteProductAsync(Expression<Func<Product, bool>> exp)
        {
            await _productRepository.DeleteProductAsync(exp);
        }

        public async Task<Product> FindProductAsync(Expression<Func<Product, bool>> exp)
        {
            return await _productRepository.FindProductAsync(exp);
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _productRepository.GetAllProductAsync();
        }

        public async Task InsertProductAsync(Product product)
        {
            await _productRepository.InsertProductAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
        }
        public async Task<List<Product>> GetListProductAsync(Expression<Func<Product, bool>> exp)
        {
            return await _productRepository.GetListProductAsync(exp);
        }

        public async Task<List<Product>> GetLimitProductAsync(Expression<Func<Product, bool>> exp, int skip, int take)
        {
            return await _productRepository.GetLimitProductAsync(exp, skip, take);
        }

        public async Task<List<Product>> GetLimitProductAsync(int skip, int take)
        {
            return await _productRepository.GetLimitProductAsync(skip, take);
        }

        //ProductCategory
        public async Task InsertProductCategoryAsync(ProductCategory productCategory)
        {
            await _productRepository.InsertProductCategoryAsync(productCategory);
        }

        //轮播图
        public async Task InsertCarouselAync(Carousel carousel)
        {
            await _productRepository.InsertCarouselAync(carousel);
        }
        public async Task DeleteAllCarouselAsync()
        {
            await _productRepository.DeleteAllCarouselAsync();
        }
        public async Task DeleteCarouselAsync(Expression<Func<Carousel, bool>> exp)
        {
            await _productRepository.DeleteCarouselAsync(exp);
        }
        public async Task DeleteCarouselAsync(Carousel carousel)
        {
            await _productRepository.DeleteCarouselAsync(carousel);
        }
        public async Task<List<Carousel>> GetAllCarouselAsync()
        {
            return await _productRepository.GetAllCarouselAsync();
        }
        public async Task<Carousel> FindCarouselAsync(Expression<Func<Carousel, bool>> exp)
        {
            return await _productRepository.FindCarouselAsync(exp);
        }

    }
}
