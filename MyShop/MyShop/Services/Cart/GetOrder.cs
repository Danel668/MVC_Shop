using Microsoft.AspNetCore.Http;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Cart
{
    [Service]
    public class GetOrder
    {
        private IStockManager _stockManager;
        private ISession _session;
        public GetOrder(IHttpContextAccessor httpContextAccessor, IStockManager stockManager)
        {
            _stockManager = stockManager;
            _session = httpContextAccessor.HttpContext.Session;
        }

        public Response Do()
        {
            var cart = _session.GetString("cart");

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(cart);

            var listOfProducts = _stockManager.GetStockWithProduct().Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new CartProductViewModel
                {
                    StockId = x.Id,
                    Qty = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty,
                }).ToList();

            var costumerInfoString = _session.GetString("customer-info");

            var customerInformation = JsonConvert.DeserializeObject<CustomerInformation>(costumerInfoString);

            return new Response
            {
                Products = listOfProducts,
                CustomerInformation = new CustomerInformationViewModel
                {
                    FirstName = customerInformation.FirstName,
                    LastName = customerInformation.LastName,
                    Email = customerInformation.Email,
                    PhoneNumber = customerInformation.PhoneNumber,
                    Address1 = customerInformation.Address1,
                    Address2 = customerInformation.Address2,
                    City = customerInformation.City,
                    PostCode = customerInformation.PostCode,
                }
            };
        }

        public class Response
        {
            public CustomerInformationViewModel CustomerInformation { get; set; }
            public IEnumerable<CartProductViewModel> Products { get; set; }
        }

        public class CustomerInformationViewModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
        }

        public class CartProductViewModel
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }
    }
}
