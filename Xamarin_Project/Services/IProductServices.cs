using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;

namespace Xamarin_Project.Services
{
    public interface IProductServices
    {

        Task<bool> AddProduct(Product product);
        Task<bool> DeleteProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<Product> GetProduct(string product_name);
        Task<IEnumerable<Product>> GetProducts();

    }
}
