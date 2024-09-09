using PhoneShop.ShareLibrary.Models;
using PhoneShop.ShareLibrary.Responses;

namespace PhoneShop.ShareLibrary.Interfaces;

public interface IProduct
{
    Task<ServiceReponse> AddProduct(Product model);
    Task<List<Product>> GetAllProducts(bool featuredProducts);
}