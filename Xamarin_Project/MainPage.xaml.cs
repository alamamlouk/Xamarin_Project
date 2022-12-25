using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Project.Views;

namespace Xamarin_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SignUp_page.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Signup());
            };
            login_page.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Login());
            };
        }
    }
}
