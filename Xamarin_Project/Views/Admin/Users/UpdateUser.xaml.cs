using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Project.Views.Admin.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateUser : ContentPage
    {
        public User olduser;
        
        public UpdateUser(User u)
        {   
            InitializeComponent();
            
            UName.Text = u.Name;
            UUsername.Text = u.Username;
            UPassword.Text = u.Password;
            olduser = u;
        }
        public async void Update_User(Object sender,EventArgs e)
        {

            olduser.Name = UName.Text.ToString();
            olduser.Username = UUsername.Text.ToString();
            olduser.Password = UPassword.Text.ToString();
            await App.UserServices.AddUserAsync(olduser);
            List<User> users = (List<User>) await App.UserServices.GetUsers();

            Console.WriteLine("User list");
            foreach (User un in users)
            {
                Console.WriteLine("user name :" + un.Name);
                Console.WriteLine("user username :" + un.Username);
                Console.WriteLine("user Password :" + un.Password);

            }
            Console.WriteLine( App.UserServices.GetUsers());
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count-2]);
            await Navigation.PushAsync(new UsersListView());
         
        }
        
    }
}