using Microsoft.AspNetCore.Http;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Cart
{
    [Service]
    public class AddToCart
    {
        
        private IStockManager _stockManager;
        private ISession _session;

        public AddToCart(IHttpContextAccessor httpContextAccessor, IStockManager stockManager)
        {
            _stockManager = stockManager;
            _session = httpContextAccessor.HttpContext.Session;
        }


        public bool Do(Request request)
        {
            var cartList = new List<CartProduct>();

            var stringObject = _session.GetString("cart");


            if (!String.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }

            if (cartList.Any(x => x.StockId == request.StockId))
            {
                if (cartList.Find(x => x.StockId == request.StockId).Qty < _stockManager.GetStockById(request.StockId).Qty)
                    cartList.Find(x => x.StockId == request.StockId).Qty += request.Qty;
            }
            else
            {
                var cartProduct = new CartProduct
                {
                    StockId = request.StockId,
                    Qty = request.Qty,
                    Color = request.Color,
                    Size = request.Size,
                    Image = request.Image,
                };

                cartList.Add(cartProduct);
            }

            stringObject = JsonConvert.SerializeObject(cartList);
            _session.SetString("cart", stringObject);

            return true;
        }


        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
            public int Color { get; set; }
            public int Size { get; set; }
            public string Image { get; set; }
        }
    }
}
