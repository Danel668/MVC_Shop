using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShop.Services.AdminProducts;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        [HttpGet("")]
        public IActionResult GetProducts([FromServices] GetProducts getProducts)
        {
            return Ok(getProducts.Do());
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateProduct([FromServices] CreateProduct createProduct, [FromForm] CreateProduct.Request request)
        {
            return Ok(await createProduct.Do(request));
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromServices] GetProduct getProduct, int id)
        {
            return Ok(getProduct.Do(id));
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateProduct([FromServices] UpdateProduct updateProduct, [FromForm] UpdateProduct.Request request)
        {
            return Ok(await updateProduct.Do(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromServices] DeleteProduct deleteProduct, int id)
        {
            return Ok(await deleteProduct.Do(id));
        }
    }
}
