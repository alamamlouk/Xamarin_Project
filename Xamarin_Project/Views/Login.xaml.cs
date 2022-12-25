using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
           
        }
        public async void Login_User(Object sender, EventArgs e)
        {
            string u_entry, p_entry;
            u_entry = Username_entry.Text;
            p_entry = Password_entry.Text;
            

            try
            {   
                if (u_entry==null && p_entry==null)
                {
                    Console.WriteLine("Enter your user name and password");
                    
                }
                else
                {   
                    User old_user = await App.UserServices.GetUser(Username_entry.Text, Password_entry.Text);
                    if (old_user.Password.Equals(Password_entry.Text))
                    {
                        Navigation.PushAsync(new Welcome_Page());

                    }
                    else
                    {
                       
                        Username_entry.TextColor = Color.Red;
                        Password_entry.TextColor = Color.Red;
                        
                    }
                    
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            

        }
    }
}