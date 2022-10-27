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
    public class CheckQty
    {
        private IStockManager _stockManager;
        private ISession _session;

        public CheckQty(IStockManager stockManager, IHttpContextAccessor httpContextAccessor)
        {
            _stockManager = stockManager;
            _session = httpContextAccessor.HttpContext.Session;
        }

        public bool Do(Request request)
        {
            if (request.StockId == 0)
            {
                return false;
            }

            var stringObject = _session.GetString("cart");
            if (String.IsNullOrEmpty(stringObject))
            {
                if (request.Qty <= 0)
                    return false;

                if (request.Qty > _stockManager.GetStockById(request.StockId).Qty)
                {
                    return false;
                }
                else
                    return true;
            }

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            var allQty = request.Qty;
            if (cartList.Any(x => x.StockId == request.StockId))
            {
                allQty += cartList.FirstOrDefault(x => x.StockId == request.StockId).Qty;
            }

            if (allQty > _stockManager.GetStockById(request.StockId).Qty)
            {
                return false;
            }
            else
                return true;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }
    }
}
