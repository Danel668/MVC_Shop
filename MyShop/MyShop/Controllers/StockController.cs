using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShop.Services.AdminStock;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class StockController : Controller
    {
        [HttpGet("")]
        public IActionResult GetStock([FromServices] GetStock getStock)
        {
            return Ok(getStock.Do());
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateStock([FromServices] CreateStock createStock, [FromBody] CreateStock.Request request)
        {
            return Ok(await createStock.Do(request));
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateStock([FromServices] UpdateStock updateStock, [FromBody] UpdateStock.Request request)
        {
            return Ok(await updateStock.Do(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock([FromServices] DeleteStock deleteStock, int id)
        {
            return Ok(await deleteStock.Do(id));
        }
    }
}
