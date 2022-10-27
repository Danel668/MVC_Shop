using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.Cart;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Pages.Checkout
{
    public class PaymentModel : PageModel
    {
        public IActionResult OnGet([FromServices] GetCustomerInformation getCustomerInformation)
        {
            if (getCustomerInformation.Do() == null)
            {
                return RedirectToPage("/Checkout/CustomerInformation");
            }

            return Page();
        }

        public async Task<IActionResult> OnPost([FromServices] GetOrder getOrder, [FromServices] Services.Orders.CreateOrder createOrder)
        {
            var CartOfOrders = getOrder.Do();

            await createOrder.Do(new Services.Orders.CreateOrder.Request
            {
                FirstName = CartOfOrders.CustomerInformation.FirstName,
                LastName = CartOfOrders.CustomerInformation.LastName,
                Email = CartOfOrders.CustomerInformation.Email,
                PhoneNumber = CartOfOrders.CustomerInformation.PhoneNumber,
                Address1 = CartOfOrders.CustomerInformation.Address1,
                Address2 = CartOfOrders.CustomerInformation.Address2,
                City = CartOfOrders.CustomerInformation.City,
                PostCode = CartOfOrders.CustomerInformation.PostCode,

                Stocks = CartOfOrders.Products.Select(x => new Services.Orders.CreateOrder.StockViewModel
                {
                    StockId = x.StockId,
                    Qty = x.Qty,
                }).ToList()

            });

            return RedirectToPage("/Main/Main");
        }
    }
}
