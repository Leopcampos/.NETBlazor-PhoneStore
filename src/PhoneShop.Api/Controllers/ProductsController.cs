using Microsoft.AspNetCore.Mvc;
using PhoneShop.ShareLibrary.Interfaces;
using PhoneShop.ShareLibrary.Models;

namespace PhoneShop.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProduct productService;

    public ProductsController(IProduct productService)
    {
        this.productService = productService;
    }

    //[HttpGet]
    //public async Task<ActionResult<List<Product>>> GetAllProducts(bool featured)
    //{

    //}
}