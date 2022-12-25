using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Project.Modal;
using System.Threading.Tasks;
namespace Xamarin_Project.Services
{
    public interface IUserSerivces
    {
        Task<bool> AddUserAsync(User user);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUSer(int id);
        Task<User> GetUserById(int id);
        Task<User> GetUser(string username,string password);
        Task<IEnumerable<User>> GetUsers();



    }
}
