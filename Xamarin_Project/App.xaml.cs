using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Project.Services;
using Xamarin_Project.Views.Admin;
namespace Xamarin_Project
{
    public partial class App : Application
    {
        static UserServices _userServices;
        static ProductServices _productServices;
        static CategorieServices _categorieServices;
        public static UserServices UserServices
        {
            get
            {
                if(_userServices==null)
                {
                    _userServices = new UserServices(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Users.db3"));
                }
                return _userServices;
            }
        }
        public static ProductServices ProductServices
        {
            get
            {
                if(_productServices==null)
                {
                    _productServices = new ProductServices(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Products.db3"));
                }
                return _productServices;
            }
        }
        public static CategorieServices CategorieServices
        {
            get
            {
                if(_categorieServices==null)
                {
                    _categorieServices = new CategorieServices(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Categories.db3"));
                }
                return _categorieServices;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Admin());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
