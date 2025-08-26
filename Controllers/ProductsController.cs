using Microsoft.AspNetCore.Mvc;
using ProductInventoryApi.Models;
using ProductInventoryApi.Services;


namespace ProductInventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;
        public ProductsController(ProductService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll(
            string? category = null,
            string? search = null,
            string? sortOrder = null,
            int page = 1,
            int pageSize = 10,
            bool? lowStock = null)
        {
            var products = await _service.GetAll(category, search, sortOrder, page, pageSize, lowStock);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = await _service.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product product)
        {
            var result = await _service.Update(id, product);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}
