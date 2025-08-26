using Microsoft.EntityFrameworkCore;
using ProductInventoryApi.Models;

namespace ProductInventoryApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Description = "Gaming Laptop 16GB RAM", Price = 1500, StockQuantity = 10, Category = "Electronics", IsActive = true },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest Android Phone", Price = 800, StockQuantity = 20, Category = "Electronics", IsActive = true },
                new Product { Id = 3, Name = "Headphones", Description = "Wireless Noise Cancelling", Price = 200, StockQuantity = 15, Category = "Electronics", IsActive = true },
                new Product { Id = 4, Name = "Coffee Maker", Description = "Automatic Coffee Machine", Price = 120, StockQuantity = 8, Category = "Home Appliances", IsActive = true },
                new Product { Id = 5, Name = "Blender", Description = "High-Speed Blender", Price = 90, StockQuantity = 12, Category = "Home Appliances", IsActive = true },
                new Product { Id = 6, Name = "Office Chair", Description = "Ergonomic Chair with Lumbar Support", Price = 150, StockQuantity = 7, Category = "Furniture", IsActive = true },
                new Product { Id = 7, Name = "Desk Lamp", Description = "LED Adjustable Desk Lamp", Price = 35, StockQuantity = 25, Category = "Furniture", IsActive = true },
                new Product { Id = 8, Name = "Notebook", Description = "Hardcover Lined Notebook", Price = 10, StockQuantity = 50, Category = "Stationery", IsActive = true },
                new Product { Id = 9, Name = "Pen Set", Description = "Premium Ballpoint Pen Set", Price = 15, StockQuantity = 30, Category = "Stationery", IsActive = true },
                new Product { Id = 10, Name = "Water Bottle", Description = "Stainless Steel Bottle 1L", Price = 25, StockQuantity = 18, Category = "Kitchenware", IsActive = true },
                new Product { Id = 11, Name = "Microwave", Description = "700W Compact Microwave Oven", Price = 120, StockQuantity = 5, Category = "Home Appliances", IsActive = true },
                new Product { Id = 12, Name = "Keyboard", Description = "Mechanical Gaming Keyboard", Price = 100, StockQuantity = 12, Category = "Electronics", IsActive = true },
                new Product { Id = 13, Name = "Mouse", Description = "Wireless Optical Mouse", Price = 40, StockQuantity = 20, Category = "Electronics", IsActive = true },
                new Product { Id = 14, Name = "Monitor", Description = "24-inch Full HD Monitor", Price = 180, StockQuantity = 6, Category = "Electronics", IsActive = true },
                new Product { Id = 15, Name = "Backpack", Description = "Laptop Backpack 15-inch", Price = 60, StockQuantity = 15, Category = "Accessories", IsActive = true },
                new Product { Id = 16, Name = "Sneakers", Description = "Running Shoes Size 10", Price = 80, StockQuantity = 10, Category = "Footwear", IsActive = true },
                new Product { Id = 17, Name = "Jacket", Description = "Waterproof Winter Jacket", Price = 120, StockQuantity = 8, Category = "Clothing", IsActive = true },
                new Product { Id = 18, Name = "Sunglasses", Description = "Polarized UV Protection", Price = 50, StockQuantity = 22, Category = "Accessories", IsActive = true },
                new Product { Id = 19, Name = "Yoga Mat", Description = "Non-slip Exercise Mat", Price = 30, StockQuantity = 14, Category = "Fitness", IsActive = true },
                new Product { Id = 20, Name = "Dumbbell Set", Description = "Adjustable Dumbbells 10-30kg", Price = 200, StockQuantity = 6, Category = "Fitness", IsActive = true }
            );
        }
    }
}
