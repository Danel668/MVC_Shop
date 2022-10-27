
namespace MyShop.Domain.Models
{
    public class CartProduct
    {
        public int StockId { get; set; }
        public int Qty { get; set; }
        public int Size { get; set; }
        public int Color { get; set; }
        public string Image { get; set; }
    }
}
