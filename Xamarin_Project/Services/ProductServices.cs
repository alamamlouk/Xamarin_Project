using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;
using SQLite;

namespace Xamarin_Project.Services
{
    public class ProductServices : IProductServices
    {
        public SQLiteAsyncConnection _database;
        public ProductServices(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }
        public async Task<bool> AddProduct(Product product)
        {
            if(product.id>0)
            {
                await _database.UpdateAsync(product); 
            }
            else
            {
                await _database.InsertAsync(product);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProduct(Product product)
        {
            await _database.DeleteAsync<Product>(product);
            return await Task.FromResult(true);
        }

        public async Task<Product> GetProduct(string product_name)
        {
            return await _database.Table<Product>().Where(product=> product.Name.Equals(product_name)).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _database.Table<Product>().ToListAsync();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            await _database.UpdateAsync(product);
            return await Task.FromResult(true);
        }
    }
}
