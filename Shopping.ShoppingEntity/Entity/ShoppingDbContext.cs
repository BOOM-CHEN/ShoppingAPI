using Microsoft.EntityFrameworkCore;
using Shopping.ShoppingEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ShoppingEntity.Entity
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ShoppingDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        /// <summary>
        /// 表设置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carousel>().ToTable("T_Carousel");

            modelBuilder.Entity<Category>().ToTable("T_Category");
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(p => p.CategoryName).IsRequired().HasMaxLength(25);
            });
            /*modelBuilder.Entity<Category>().HasData(
                new Category() { Id = Guid.NewGuid() ,CategoryName = "男装"},
                new Category() { Id = Guid.NewGuid(), CategoryName = "女装" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "童装" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "运动装备" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "生鲜食品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "零食" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "饮料" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "调味品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "家具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "装饰品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "厨房用具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "手机" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "电脑" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "相机" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "家用电器" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "护肤品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "彩妆" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "香水" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "玩具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "学习用具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "婴儿用品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "小说" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "教育书籍" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "杂志" }
            );*/

            modelBuilder.Entity<Order>().ToTable("T_Order")
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Password>().ToTable("T_UserPassword");
            modelBuilder.Entity<Password>(entity =>
            {
                entity.Property(p => p.PublicKey).IsRequired();
                entity.Property(p => p.IV).IsRequired();
            });

            modelBuilder.Entity<Product>().ToTable("T_Product");
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.ProductName).IsRequired().HasMaxLength(128);
                entity.Property(p => p.ProductDescription).IsRequired().HasMaxLength(512);
                entity.Property(p => p.ProductPrice).IsRequired();
                entity.Property(p => p.ProductDate).IsRequired();
                entity.Property(p => p.ProductDiscount).HasDefaultValue(1);
                entity.Property(p => p.ProductInventory).IsRequired();
            });
            modelBuilder.Entity<Product>()
                .HasOne(s => s.ShoppingCart)
                .WithMany(u => u.Products)
                .HasForeignKey(k => k.ShoppingCartId);

            modelBuilder.Entity<ShoppingCart>().ToTable("T_ShoppingCart");
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(s => s.User)
                .WithOne(u => u.ShoppingCart)
                .HasForeignKey<ShoppingCart>(u => u.UserId);

            modelBuilder.Entity<User>().ToTable("T_User");
            modelBuilder.Entity<User>()
                .HasOne(u => u.Passwords)
                .WithOne(p => p.User)
                .HasForeignKey<Password>(f => f.UserId);

            modelBuilder.Entity<ProductCategory>().ToTable("T_ProductCategory");
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId,pc.CategoryId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(p => p.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(c => c.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(c => c.CategoryId);


            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = Guid.NewGuid() ,CategoryName = "男装"},
                new Category() { Id = Guid.NewGuid(), CategoryName = "女装" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "童装" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "运动装备" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "生鲜食品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "零食" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "饮料" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "调味品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "家具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "装饰品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "厨房用具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "手机" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "电脑" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "相机" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "家用电器" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "护肤品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "彩妆" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "香水" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "玩具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "学习用具" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "婴儿用品" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "小说" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "教育书籍" },
                new Category() { Id = Guid.NewGuid(), CategoryName = "杂志" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), ProductCategory = "小说", ProductName = "龙族1", ProductInventory = 925, ProductPrice = 99, ProductDescription = "江南小说", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "小说", ProductName = "龙族2", ProductInventory = 854, ProductPrice = 109, ProductDescription = "江南小说", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "小说", ProductName = "龙族3", ProductInventory = 658, ProductPrice = 125, ProductDescription = "江南小说", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "小说", ProductName = "龙族4", ProductInventory = 356, ProductPrice = 169, ProductDescription = "江南小说", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "小说", ProductName = "龙族5", ProductInventory = 500, ProductPrice = 135, ProductDescription = "江南小说", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "手机", ProductName = "小米1", ProductInventory = 925, ProductPrice = 250, ProductDescription = "小米手机", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "手机", ProductName = "小米2", ProductInventory = 655, ProductPrice = 165, ProductDescription = "小米手机", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "电脑", ProductName = "联想7000p", ProductInventory = 300, ProductPrice = 9555, ProductDescription = "联想系列", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                new Product() { Id = Guid.NewGuid(), ProductCategory = "电脑", ProductName = "联想y7000p", ProductInventory = 255, ProductPrice = 8555, ProductDescription = "联想系列", ProductDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
            );
        }
    }
}
    
