using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.AdminOrders
{
    [Service]
    public class GetOrderById
    {
        private IOrderManager _orderManager;

        public GetOrderById(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public Response Do(int id)
        {
           return _orderManager.GetAllOrdersWithProducts().Where(x => x.Id == id).Select(x => new Response
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Address1 = x.Address1,
                Address2 = x.Address2,
                PhoneNumber = x.PhoneNumber,
                City = x.City,
                PostCode = x.PostCode,
                Status = x.Status.ToString(),

               Products = x.OrderStocks.Select(y => new ProductViewModel
               {
                   ProductName = y.Stock.Product.Name,
                   Size = y.Stock.Size.ToString(),
                   Color = y.Stock.Color.ToString(),
                   Qty = y.Stock.Qty,
               })
           }).FirstOrDefault();
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
            public string Status { get; set; }
            public IEnumerable<ProductViewModel> Products { get; set; }
        }

        public class ProductViewModel
        {
            public string ProductName { get; set; }
            public string Size { get; set; }
            public string Color { get; set; }
            public int Qty { get; set; }
        }
    }
}
