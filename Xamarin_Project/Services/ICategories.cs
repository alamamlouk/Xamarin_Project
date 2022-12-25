using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;

namespace Xamarin_Project.Services
{
    public interface ICategories
    {
        Task<bool> AddCategoriesAsync(Categories categories);
        Task<bool> UpdateCategories(Categories categories);
        Task<bool> DeleteCategories(Categories categories);
        Task<Categories> GetCategories(string name);
        Task<IEnumerable<Categories>> GetCategories();
    }
}
