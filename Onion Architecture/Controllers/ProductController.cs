using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductService;

namespace Onion_Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(nameof(GetProduct))]
        public IActionResult GetProduct(int id)
        {
            return Ok(_productService.GetProduct(id));
        }

        [HttpGet(nameof(GetAllProducts))]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpPost]
        public IActionResult InsertProduct(Product product)
        {
            _productService.Insert(product);
            return Ok("Product inserted");
        }

    }
}
