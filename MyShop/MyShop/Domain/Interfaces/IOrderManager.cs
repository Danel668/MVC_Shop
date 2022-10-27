using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Domain.Interfaces
{
    public interface IOrderManager
    {
        Task<int> CreateOrder(Order order);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllOrdersWithProducts();
        Order GetOrderById(int id);
        Task<bool> UpdateOrderStatus(Order order);
    }
}
