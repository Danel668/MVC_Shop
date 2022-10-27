using MyShop.Domain.Interfaces;
using System.Threading.Tasks;

namespace MyShop.Services.AdminProducts
{
    [Service]
    public class DeleteProduct
    {
        private IFileManager _fileManager;
        private IProductManager _productManager;

        public DeleteProduct(IProductManager productManager, IFileManager fileManager)
        {
            _fileManager = fileManager;
            _productManager = productManager;
        }

        public async Task<bool> Do(int id)
        {
            var product = _productManager.GetProductById(id);
            if (!_fileManager.RemoveImage(product.Image))
                return false;

            if (await _productManager.DeleteProduct(id) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
