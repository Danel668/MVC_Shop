using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.Cart;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Pages.Checkout
{
    public class CustomerInformationModel : PageModel
    {
        [BindProperty]
        public AddCustomerInformation.Request CustomerInformation { get; set; }

        public IEnumerable<GetCart.Response> Cart { get; set; }

        public IActionResult OnGet([FromServices] GetCustomerInformation getCustomerInformation, [FromServices] GetCart getCart)
        {
            if (getCustomerInformation.Do() == null)
            {
                Cart = getCart.Do();
                if (Cart.Count() == 0)
                {
                    return RedirectToPage("/Main/Main");
                }
                return Page();
            }
            else
                return RedirectToPage("/Checkout/Payment");
        }

        public IActionResult OnPost([FromServices] AddCustomerInformation addCustomerInformation, [FromServices] GetCart getCart)
        {
            if (!ModelState.IsValid)
            {
                Cart = getCart.Do();
                return Page();
            }

            addCustomerInformation.Do(CustomerInformation);

            return RedirectToPage("/Checkout/Payment");
        }
    }
}
