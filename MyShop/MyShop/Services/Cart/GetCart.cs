using Microsoft.AspNetCore.Http;
using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Cart
{
    [Service]
    public class GetCart
    {
        private IStockManager _stockManager;
        private ISession _session;

        public GetCart(IHttpContextAccessor httpContextAccessor, IStockManager stockManager)
        {
            _stockManager = stockManager;
            _session = httpContextAccessor.HttpContext.Session;
        }

        public IEnumerable<Response> Do()
        {
            var stringObject = _session.GetString("cart");

            if (String.IsNullOrEmpty(stringObject))
                return new List<Response>();

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            var reponse = _stockManager.GetStockWithProduct().Where(x => cartList.Any(y => x.Id == y.StockId)).Select(x => new Response
            {
                Name = x.Product.Name,
                Image = x.Product.Image,
                Price = $"${x.Product.Price.ToString("N2")}",
                RealPrice = x.Product.Price,
                StockId = x.Id,
                Color = x.Color,
                Size = x.Size,
                AllQty = x.Qty,
                Qty = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty,
            }).ToList();

            return reponse;
        }

        public class Response
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public decimal RealPrice { get; set; }
            public int StockId { get; set; }
            public int Qty { get; set; }
            public int AllQty { get; set; }
            public string Image { get; set; }
            public ProductColor Color { get; set; }
            public ProductSize Size { get; set; }
        }
    }
}
