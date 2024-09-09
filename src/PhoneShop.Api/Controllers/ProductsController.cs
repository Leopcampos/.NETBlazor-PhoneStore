using Microsoft.AspNetCore.Mvc;
using PhoneShop.ShareLibrary.Interfaces;
using PhoneShop.ShareLibrary.Models;
using PhoneShop.ShareLibrary.Responses;

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

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts(bool featured)
    {
        var products = await productService.GetAllProducts(featured);
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceReponse>> AddProduct(Product model)
    {
        if (model is null) return BadRequest("Model is null");
        var response = await productService.AddProduct(model);
        return Ok(response);
    }
}