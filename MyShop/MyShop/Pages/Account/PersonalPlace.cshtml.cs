using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Domain.Models;
using MyShop.Services.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Pages.Account
{
    public class PersonalPlaceModel : PageModel
    {
        private UserManager<User> _userManager;

        public PersonalPlaceModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public User _User { get; set; }
        public IEnumerable<GetOrdersByUserId.Response> Orders { get; set; }

        public async Task OnGet([FromServices] GetOrdersByUserId getOrdersByUserId)
        {
            Orders = await getOrdersByUserId.Do();
            _User = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
        }
    }
}
