using MyShop.Domain.Interfaces;
using System.Threading.Tasks;

namespace MyShop.Services.AdminStock
{
    [Service]
    public class DeleteStock
    {
        private IStockManager _stockManager;

        public DeleteStock(IStockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public async Task<bool> Do(int id)
        {
            await _stockManager.DeleteStock(id);

            return true;
        }
    }
}
