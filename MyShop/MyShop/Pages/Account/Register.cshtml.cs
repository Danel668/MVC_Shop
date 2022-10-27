using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.UserAuthorize;
using System.Threading.Tasks;

namespace MyShop.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Services.UserAuthorize.Register.Request RegisterViewModel { get; set; }

        public IActionResult OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Main/Main");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost([FromServices] Register register)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (await register.Do(RegisterViewModel))
            {
                return RedirectToPage("/Main/Main");
            }
            return Page();
        }
    }
}
