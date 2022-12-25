using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;

namespace Xamarin_Project.Services
{
    public class CategorieServices : ICategories
    {
        public SQLiteAsyncConnection _database;
        public CategorieServices(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        public async Task<bool> AddCategoriesAsync(Categories categories)
        {
            if (categories.id > 0)
            {
                await _database.UpdateAsync(categories);
            }
            else
            {
                await _database.InsertAsync(categories);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCategories(Categories categories)
        {
            await _database.DeleteAsync<Categories>(categories);
            return await Task.FromResult(true);
        }

        public async Task<Categories> GetCategories(string name)
        {
            return await _database.Table<Categories>().Where(categories => categories.Name.Equals(name)).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Categories>> GetCategories()
        {
            return await _database.Table<Categories>().ToListAsync();
        }


        public async Task<bool> UpdateCategories(Categories categories)
        {
            await _database.UpdateAsync(categories);
            return await Task.FromResult(true);
        }
    }
}
