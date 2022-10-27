using Microsoft.AspNetCore.Identity;
using MyShop.Domain.Models;
using System.Threading.Tasks;

namespace MyShop.Services.UserAuthorize
{
    [Service]
    public class Logout
    {
        private SignInManager<User> _signInManager;
        public Logout(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<bool> Do()
        {
            await _signInManager.SignOutAsync();
            return true;
        }
    }
}
