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
    public class CreateOrder
    {
        private UserManager<User> _userManager;
        private IHttpContextAccessor _httpContextAccessor;
        private IOrderManager _orderManager;

        public CreateOrder(IOrderManager orderManager, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _orderManager = orderManager;
        }

        public async Task Do(Request request)
        {
            var order = new Order
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address1 = request.Address1,
                Address2 = request.Address2,
                City = request.City,
                PostCode = request.PostCode,
                Status = Domain.Enums.OrderStatus.Pending,
                OrderStocks = request.Stocks.Select(x => new OrderStock
                {
                    StockId = x.StockId,
                    Qty = x.Qty,
                }).ToList()
            };

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);

                order.UserId = user.Id;
            }
            await _orderManager.CreateOrder(order);

        }

        public class Request
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
            public List<StockViewModel> Stocks { get; set; }
        }

        public class StockViewModel
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }
    }
}
