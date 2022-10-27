using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class ProductManager : IProductManager
    {
        private ApplicationDbContext _ctx;

        public ProductManager(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<int> CreateProduct(Product product)
        {
            _ctx.Products.Add(product);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<int> DeleteProduct(int id)
        {
            var product = _ctx.Products.FirstOrDefault(p => p.Id == id);
            _ctx.Products.Remove(product);
            return await _ctx.SaveChangesAsync();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _ctx.Products.FirstOrDefault(x => x.Id == id);
        }

        public Product GetProductByName(string name)
        {
            return _ctx.Products.Include(y => y.Stock).FirstOrDefault(x => x.Name == name);
        }

        public async Task<int> UpdateProduct(Product product)
        {
            _ctx.Products.Update(product);
            return await _ctx.SaveChangesAsync();
        }

        public IEnumerable<Product> GetProductsWithStock()
        {
            return _ctx.Products.Include(x => x.Stock).ToList();
        }

        public Product GetProductWithStock(int id)
        {
            return _ctx.Products.Include(x => x.Stock).FirstOrDefault(y => y.Id == id);
        }
    }
}
