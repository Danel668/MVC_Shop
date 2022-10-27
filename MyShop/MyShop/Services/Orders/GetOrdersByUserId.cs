using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services.Orders
{
    [Service]
    public class GetOrdersByUserId
    {
        private IOrderManager _orderManager;
        private UserManager<User> _userManager;
        private IHttpContextAccessor _httpContextAccessor;

        public GetOrdersByUserId(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor, IOrderManager orderManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<Response>> Do()
        {
            var user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);

            var id = user.Id;

            return _orderManager.GetAllOrdersWithProducts().Where(x => x.UserId == id).Select(x => new Response  
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Address1 = x.Address1,
                Address2 = x.Address2,
                City = x.City,
                PostCode = x.PostCode,
                Status = (int)x.Status

            }).ToList();

        }

        public class Response
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
            public int Status { get; set; }
        }
    }
}
