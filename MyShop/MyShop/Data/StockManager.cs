using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class StockManager : IStockManager
    {
        private ApplicationDbContext _ctx;

        public StockManager(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<int> CreateStock(Stock stock)
        {
            _ctx.Stock.Add(stock);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<int> DeleteStock(int id)
        {
            var stock = _ctx.Stock.FirstOrDefault(x => x.Id == id);
            _ctx.Stock.Remove(stock);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<int> UpdateStockRange(List<Stock> stockList)
        {
            _ctx.Stock.UpdateRange(stockList);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<int> UpdateStock(Stock stock)
        {
            _ctx.Stock.Update(stock);
            return await _ctx.SaveChangesAsync();
        }

        public IEnumerable<Stock> GetStockWithProduct()
        {
            return _ctx.Stock.Include(x => x.Product).AsEnumerable();
        }

        public Stock GetStockById(int id)
        {
            return _ctx.Stock.FirstOrDefault(x => x.Id == id);
        }

    }
}
