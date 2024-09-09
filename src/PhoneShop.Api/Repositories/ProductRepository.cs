using Microsoft.EntityFrameworkCore;
using PhoneShop.Api.Data;
using PhoneShop.ShareLibrary.Interfaces;
using PhoneShop.ShareLibrary.Models;
using PhoneShop.ShareLibrary.Responses;

namespace PhoneShop.Api.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
            => _context = context;

        public async Task<ServiceReponse> AddProduct(Product model)
        {
            if (model is null)
                return new ServiceReponse(false, "Product is null");
            var (flag, message) = await CheckName(model.Name!);
            if (flag)
            {
                _context.Products.Add(model);
                await Commit();
                return new ServiceReponse(true, "Product Saved");
            }

            return new ServiceReponse(flag, message);
        }

        public async Task<List<Product>> GetAllProducts(bool featuredProducts)
        {
            if (featuredProducts)
                return await _context.Products.Where(p => p.Featured).ToListAsync();
            else
                return await _context.Products.ToListAsync();
        }

        private async Task<ServiceReponse> CheckName(string name)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Name.ToLower().Equals(name.ToLower()));
            return product is null ? new ServiceReponse(true, null!) : new ServiceReponse(false, "Product already exist");
        }

        private async Task Commit() 
            => await _context.SaveChangesAsync();
    }
}