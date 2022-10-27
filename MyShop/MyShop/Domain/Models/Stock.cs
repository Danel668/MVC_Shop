using MyShop.Domain.Enums;
using System.Collections.Generic;

namespace MyShop.Domain.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ICollection<OrderStock> OrderStocks { get; set; }
    }
}
