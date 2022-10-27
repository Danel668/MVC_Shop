using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Domain.Interfaces
{
    public interface IStockManager
    {
        Task<int> CreateStock(Stock stock);
        Task<int> DeleteStock(int id);
        Task<int> UpdateStockRange(List<Stock> stockList);
        Task<int> UpdateStock(Stock stock);

        IEnumerable<Stock> GetStockWithProduct();
        Stock GetStockById(int id);
    }
}
