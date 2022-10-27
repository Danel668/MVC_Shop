using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShop.Services.AdminOrders;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        [HttpGet("{status}")]
        public IActionResult GetOrders([FromServices] GetOrdersByStatus getOrdersByStatus, int status)
        {
            return Ok(getOrdersByStatus.Do(status));
        }

        [HttpGet("id/{id}")]
        public IActionResult GetOrder([FromServices] GetOrderById getOrderById, int id)
        {
            return Ok(getOrderById.Do(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder([FromServices] UpdateOrder updateOrder, int id)
        {
            return Ok(await updateOrder.Do(id));
        }

    }
}
