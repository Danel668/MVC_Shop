using Microsoft.EntityFrameworkCore.Internal;
using MyShop.Domain.Interfaces;
using System.Linq;

namespace MyShop.Services.Cart
{
    [Service]
    public class GetStockId
    {
        private IProductManager _productManager;

        public GetStockId(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public int Do(Request request)
        {
            var currentStock = _productManager.GetProductWithStock(request.ProductId).Stock
                .Where(x => (x.Color == (Domain.Enums.ProductColor)request.Color) && (x.Size == (Domain.Enums.ProductSize)request.Size))
                .FirstOrDefault()?.Id ?? 0;

            return currentStock;
        }

        public class Request
        {
            public int ProductId { get; set; }
            public int Color { get; set; }
            public int Size { get; set; }
        }
    }


}
