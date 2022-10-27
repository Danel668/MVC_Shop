using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyShop.Services.UserAuthorize;
using System.Threading.Tasks;

namespace MyShop.Pages.Account
{
    public class LoginModel : PageModel
    {
       [BindProperty]
       public Services.UserAuthorize.Login.Request LoginViewModel { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost([FromServices] Login login)
        {
            if (await login.Do(LoginViewModel))
            {
                return RedirectToPage("/Main/Main");
            }
            return Page();
        }
    }
}
