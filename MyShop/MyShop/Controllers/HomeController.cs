using Microsoft.AspNetCore.Mvc;
using MyShop.Domain.Interfaces;
using MyShop.Services.Cart;
using MyShop.Services.Products;

namespace MyShop.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [HttpPost("")]
        public IActionResult CheckQty([FromServices] CheckQty checkQty, [FromBody] CheckQty.Request request)
        {
            return Ok(checkQty.Do(request));
        }

        [HttpPost("")]
        public IActionResult GetStockId([FromServices] GetStockId getStockId, [FromBody] GetStockId.Request request)
        {
            return Ok(getStockId.Do(request));
        }

        [HttpPost("")]
        public IActionResult AddToCart([FromServices] AddToCart addToCart, [FromBody] AddToCart.Request request)
        {
            return Ok(addToCart.Do(request));
        }

        [HttpGet("/Image/{image}")]
        public IActionResult Image([FromServices] IFileManager fileManager, string image)
        {
            return new FileStreamResult(fileManager.ImageStream(image), $"image/{image.Substring(image.LastIndexOf('.') + 1)}");
        }

        [HttpGet("")]
        public IActionResult GetProducts([FromServices] GetProducts getProducts)
        {
            return Ok(getProducts.Do());
        }

        [HttpGet("")]
        public IActionResult GetAllCategories([FromServices] GetAllCategories getAllCategories)
        {
            return Ok(getAllCategories.Do());
        }
    }

}
