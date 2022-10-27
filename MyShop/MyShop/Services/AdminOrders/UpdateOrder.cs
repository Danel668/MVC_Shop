using MyShop.Domain.Interfaces;
using System.Threading.Tasks;

namespace MyShop.Services.AdminOrders
{
    [Service]
    public class UpdateOrder
    {
        private IOrderManager _orderManager;

        public UpdateOrder(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public async Task<bool> Do(int id)
        {
            var order = _orderManager.GetOrderById(id);
            if (order.Status != Domain.Enums.OrderStatus.Completed)
            {
                await _orderManager.UpdateOrderStatus(order);
            }
            return true;
        }
    }
}
