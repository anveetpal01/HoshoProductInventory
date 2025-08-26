using Microsoft.EntityFrameworkCore;
using ProductInventoryApi.Data;
using ProductInventoryApi.Models;

namespace ProductInventoryApi.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context) => _context = context;

        // Get All (with filter, sort, search, pagination, low-stock alert)
        public async Task<IEnumerable<Product>> GetAll(string? category, string? search, string? sortOrder, int page, int pageSize, bool? lowStock)
        {
            var query = _context.Products.Where(p => p.IsActive).AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(p => p.Category == category);

            if (!string.IsNullOrEmpty(search))
                query = query.Where(p => p.Name.Contains(search) || p.Description.Contains(search));

            if (lowStock == true)
                query = query.Where(p => p.StockQuantity <= 5);
            else if (lowStock == false)
                query = query.Where(p => p.StockQuantity > 5);
            if (sortOrder == "asc")
                query = query.OrderBy(p => p.Price);
            else if (sortOrder == "desc")
                query = query.OrderByDescending(p => p.Price);

            // Pagination
            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task<Product> GetById(int id) =>
            await _context.Products.FirstOrDefaultAsync(p => p.Id == id && p.IsActive);

        public async Task<Product> Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> Update(int id, Product updated)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null || !product.IsActive) return false;

            product.Name = updated.Name;
            product.Description = updated.Description;
            product.Price = updated.Price;
            product.StockQuantity = updated.StockQuantity;
            product.Category = updated.Category;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null || !product.IsActive) return false;

            product.IsActive = false; // Soft delete
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
