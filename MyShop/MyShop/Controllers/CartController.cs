using Microsoft.AspNetCore.Mvc;
using MyShop.Domain.Interfaces;
using MyShop.Services.Cart;

namespace MyShop.Controllers
{
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        [HttpPost("{stockId}")]
        public IActionResult AddOne([FromServices] AddToCart addToCart, [FromServices] IStockManager stockManager, int stockId)
        {
            var _request = new AddToCart.Request
            {
                Qty = 1,
                StockId = stockId,
                Color = (int)stockManager.GetStockById(stockId).Color,
                Size = (int)stockManager.GetStockById(stockId).Size,
            };
           
            var succes = addToCart.Do(_request);

            if (succes)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Failed to add to cart");
            }
        }

        [HttpPost("{stockId}")]
        public IActionResult RemoveOne([FromServices] RemoveFromCart removeFromCart, int stockId)
        {
            var _request = new RemoveFromCart.Request
            {
                All = false,
                StockId = stockId
            };

            var succes = removeFromCart.Do(_request);

            if (succes)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Failed to remove from cart");
            }

        }

        [HttpPost("{stockId}")]
        public IActionResult RemoveAll([FromServices] RemoveFromCart removeFromCart, int stockId)
        {
            var _request = new RemoveFromCart.Request
            {
                All = true,
                StockId = stockId
            };

            var succes = removeFromCart.Do(_request);

            if (succes)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Failed to remove all from cart");
            }
        }

    }
}
