using Microsoft.AspNetCore.Http;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyShop.Services.Cart
{
    [Service]
    public class RemoveFromCart
    {
        private IProductManager _productManager;
        private ISession _session;

        public RemoveFromCart(IHttpContextAccessor httpContextAccessor, IProductManager productManager)
        {
            _productManager = productManager;
            _session = httpContextAccessor.HttpContext.Session;
        }

        public bool Do(Request request)
        {
            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);

            if (cartList.Find(x => x.StockId == request.StockId).Qty == 1 || request.All)
            {
                var item = cartList.Find(x => x.StockId == request.StockId);
                cartList.Remove(item);
            }
            else
                cartList.Find(x => x.StockId == request.StockId).Qty -= 1;

            stringObject = JsonConvert.SerializeObject(cartList);

            _session.SetString("cart", stringObject);

            return true;

        }

        public class Request
        {
            public int StockId { get; set; }
            public bool All { get; set; }
        }
    }
}
