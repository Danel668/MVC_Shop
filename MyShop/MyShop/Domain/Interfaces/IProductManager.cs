using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyShop.Domain.Interfaces
{
    public interface IProductManager
    {
        Task<int> CreateProduct(Product product);

        Task<int> DeleteProduct(int id);

        Task<int> UpdateProduct(Product product);

        Product GetProductById(int id);

        Product GetProductByName(string name);

        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductsWithStock();

        Product GetProductWithStock(int id);
    }
}
