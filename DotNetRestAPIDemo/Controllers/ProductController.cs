using DotNetRestAPIDemo.Interface;
using DotNetRestAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetRestAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetProductsAsync());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productService.GetProductByIdAsync(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            return Ok(await _productService.AddProductAsync(product));
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Product product)
        {
            return Ok(await _productService.UpdateProductAsync(product));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _productService.RemoveProductAsync(id));
        }
    }
}
