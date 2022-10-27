using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.Cart;
using System.Collections.Generic;

namespace MyShop.Pages.Main
{
    public class CartModel : PageModel
    {
        public IEnumerable<GetCart.Response> Cart { get; set; }

        public void OnGet([FromServices] GetCart getCart)
        {
            Cart = getCart.Do();

        }
    }
}
