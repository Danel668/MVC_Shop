using Microsoft.AspNetCore.Mvc;
using MyShop.Services.UserAuthorize;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    public class UserController : Controller
    {
       public async Task<IActionResult> Logout([FromServices] Logout logout)
        {
            await logout.Do();
            return RedirectToPage("/Main/Main");
        }
    }
}
