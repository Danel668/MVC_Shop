using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.Products;

namespace MyShop.Pages.Main
{
    public class ProducttModel : PageModel
    {
        public GetProduct.Response Product { get; set; }

        public void OnGet([FromServices] GetProduct getProduct, string name)
        {
            Product = getProduct.Do(name);
        }

    }
}
