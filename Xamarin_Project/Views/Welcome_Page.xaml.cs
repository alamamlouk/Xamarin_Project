using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Views.Iset;
using Xamarin_Project.Views.Cars_rolls;
using Xamarin_Project.Views.Shop;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome_Page : ContentPage
    {
        public Welcome_Page()
        {
            InitializeComponent();
            Iset_btn.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Iset_Dep());
            };
            Cars_btn.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Cars_show());
            };
            Shop_btn.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Mall_items());
            };
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }

}