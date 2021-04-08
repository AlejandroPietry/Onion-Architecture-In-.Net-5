using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion_Architecture.Controllers
{
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult GetProduct(int id)
        {
            return  Ok(_productService.GetProduct(id));
        }

        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

    }
}
