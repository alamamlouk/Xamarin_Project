using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;

namespace Xamarin_Project.Services
{
    public class UserServices : IUserSerivces
    {
        public SQLiteAsyncConnection _database;
        public UserServices(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        public async Task<bool> AddUserAsync(User user)
        {
           if(user.ID!=0)
            {
                await _database.UpdateAsync(user);
            }
           else
            {
                await _database.InsertAsync(user);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteUSer(int id)
        {
            await _database.DeleteAsync<User>(id);
            return await Task.FromResult(true);
        }

    

        public async Task<User> GetUser(string username ,string password)
        {

            return await _database.Table<User>().Where(user => user.Username.Equals(username) && user.Password.Equals(password)).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _database.Table<User>().Where(user => user.ID==id).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _database.Table<User>().ToListAsync();

        }

        public async Task<bool> UpdateUser(User user)
        {
            
                await _database.UpdateAsync(user);
            return await Task.FromResult(true);
        }

    }
}
