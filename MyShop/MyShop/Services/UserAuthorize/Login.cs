using Microsoft.AspNetCore.Identity;
using MyShop.Domain.Models;
using System.Threading.Tasks;

namespace MyShop.Services.UserAuthorize
{
    [Service]
    public class Login
    {
        private SignInManager<User> _signInManager;

        public Login(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<bool> Do(Request request)
        {
            var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, false, false);
            if (!result.Succeeded)
            {
                return false;
            }
            return true;
        }

        public class Request
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
