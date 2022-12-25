using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Project.Services;

namespace Xamarin_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }
        public  async void Signup_User(Object sender ,EventArgs e)
        {
            User user = new User();
            user.Name = Name_entry.Text;
            user.Username = Username_entry.Text;
            user.Password = Password_entry.Text;
            if(await App.UserServices.AddUserAsync(user))
            {
                Console.WriteLine("the add is done");
                Navigation.PushAsync(new Welcome_Page());

                List<User> users = (List<User>)await App.UserServices.GetUsers();

                Console.WriteLine("User list");
                foreach(User u in users)
                {
                    Console.WriteLine("user name :" + u.Name);
                    Console.WriteLine("user username :" + u.Username);
                    Console.WriteLine("user Password :" + u.Password);

                }
            }
            
        }
    }
}