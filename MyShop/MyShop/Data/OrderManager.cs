using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class OrderManager : IOrderManager
    {
        private ApplicationDbContext _ctx;

        public OrderManager(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<int> CreateOrder(Order order)
        {
            _ctx.Orders.Add(order);
            return await _ctx.SaveChangesAsync();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _ctx.Orders.ToList();
        }

        public IEnumerable<Order> GetAllOrdersWithProducts()
        {
            return _ctx.Orders.Include(x => x.OrderStocks).ThenInclude(x => x.Stock).ThenInclude(x => x.Product).AsEnumerable();
        }

        public Order GetOrderById(int id)
        {
            return _ctx.Orders.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateOrderStatus(Order order)
        {
            order.Status += 1;
            _ctx.Orders.Update(order);
            return await _ctx.SaveChangesAsync() > 0;
        }
    }
}
