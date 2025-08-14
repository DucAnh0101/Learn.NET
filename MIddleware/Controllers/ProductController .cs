using Microsoft.AspNetCore.Mvc;
using MIddleware.Filters;
using MIddleware.Models;
using MIddleware.Services;

namespace MIddleware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomActionFilter))]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            Console.WriteLine("[Controller] Calling business layer");
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Console.WriteLine("[Controller] Product created");
            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Console.WriteLine("[Controller] Fetching product by ID");
            var product = _service.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception("Product not found"); // Để test ErrorHandlingMiddleware
            }
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Console.WriteLine($"[Controller] Deleting product {id}");
            return NoContent();
        }
    }
}
