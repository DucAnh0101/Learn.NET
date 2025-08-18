using DataAccessLayer.ReqDTO;
using Microsoft.AspNetCore.Mvc;
using Services.Filters;
using Services.Services;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(LoggingActionFilter))]
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
            var res = _service.GetAll();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var res = _service.GetById(id);
            if (res == null) return NotFound("Product not found");
            return Ok(res);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductCreateReq req)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var res = _service.Create(req);
            return CreatedAtAction(nameof(GetProductById), new { id = res.Id }, res);

        }
    }
}
