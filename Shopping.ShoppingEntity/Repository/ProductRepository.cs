using Microsoft.EntityFrameworkCore;
using Shopping.ShoppingEntity.Entity;
using Shopping.ShoppingEntity.IRepository;
using Shopping.ShoppingEntity.IRepository.IBase;
using Shopping.ShoppingEntity.Models;
using Shopping.ShoppingEntity.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly IBaseRepository<Product> _baseRepository;
        private readonly ShoppingDbContext _shoppingDbContext;
        public ProductRepository(ShoppingDbContext shoppingDbContext, IBaseRepository<Product> baseRepository) : base(shoppingDbContext)
        {
            _baseRepository = baseRepository;
            _shoppingDbContext = shoppingDbContext;
        }

        public async Task DeleteAllProductAsync()
        {
            await _baseRepository.DeleteAllAsync();
        }

        public async Task DeleteProductAsync(Expression<Func<Product, bool>> exp)
        {
            await _baseRepository.DeleteAsync(exp);
        }

        public async Task<Product> FindProductAsync(Expression<Func<Product, bool>> exp)
        {
            return await _baseRepository.FindAsync(exp);
        }

        public async Task<List<Product>> GetListProductAsync(Expression<Func<Product, bool>> exp)
        {
            return await _baseRepository.GetListAsync(exp);
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task InsertProductAsync(Product product)
        {
            await _baseRepository.InsertAsync(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _baseRepository.UpdateAsync(product);
        }

        public Task<List<Product>> GetLimitProductAsync(Expression<Func<Product, bool>> exp, int skip, int take)
        {
            return _baseRepository.GetLimitAsync(exp, skip, take);
        }

        public Task<List<Product>> GetLimitProductAsync(int skip, int take)
        {
            return _baseRepository.GetLimitAsync(skip, take);
        }

        //ProductCategory
        public async Task InsertProductCategoryAsync(ProductCategory productCategory)
        {
            await _shoppingDbContext.Set<ProductCategory>().AddAsync(productCategory);
            await _shoppingDbContext.SaveChangesAsync();
        }

        //轮播图
        public async Task InsertCarouselAync(Carousel carousel)
        {
            await _shoppingDbContext.Set<Carousel>().AddAsync(carousel);
            await _shoppingDbContext.SaveChangesAsync();
        }
        public async Task DeleteAllCarouselAsync()
        {
            await _shoppingDbContext.Set<Carousel>().ExecuteDeleteAsync();
            await _shoppingDbContext.SaveChangesAsync();
        }
        public async Task DeleteCarouselAsync(Expression<Func<Carousel, bool>> exp)
        {
            var entity = await FindCarouselAsync(exp);
            _shoppingDbContext.Set<Carousel>().Remove(entity);
            await _shoppingDbContext.SaveChangesAsync();
        }
        public async Task DeleteCarouselAsync(Carousel carousel)
        {
            _shoppingDbContext.Set<Carousel>().Remove(carousel);
            await _shoppingDbContext.SaveChangesAsync();
        }

        public async Task<Carousel> FindCarouselAsync(Expression<Func<Carousel, bool>> exp)
        {
            return await _shoppingDbContext.Set<Carousel>().Where(exp).SingleOrDefaultAsync();
        }

        public async Task<List<Carousel>> GetAllCarouselAsync()
        {
            return await _shoppingDbContext.Set<Carousel>().ToListAsync();
        }
    }
}
