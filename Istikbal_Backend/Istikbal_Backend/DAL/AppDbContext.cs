using Istikbal_Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Istikbal_Backend.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    { 

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDest> CategoryDests { get; set; }
        public DbSet<CategoryIn> CategoryIns { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Slider> Sliders     { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryIn> ProductCategoryIns { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Order> Order { get; set; }



    }
}
