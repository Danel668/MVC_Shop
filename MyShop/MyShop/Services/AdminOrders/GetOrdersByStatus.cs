using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.AdminOrders
{
    [Service]
    public class GetOrdersByStatus
    {
        private IOrderManager _orderManager;

        public GetOrdersByStatus(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public IEnumerable<Response> Do(int status)
        {
            return _orderManager.GetAllOrders().Where(x => x.Status == (OrderStatus)status).Select(x => new Response
            {
                Id = x.Id,
                Email = x.Email,
                City = x.City
            }).ToList();
        }


        public class Response
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
        }
    }
}
