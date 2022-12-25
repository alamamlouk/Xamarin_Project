using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Project.Views.Admin.Users;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Project.Views.Admin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminFlyout : ContentPage
    {
        public ListView ListView;

        public AdminFlyout()
        {
            InitializeComponent();

            BindingContext = new AdminFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class AdminFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AdminFlyoutMenuItem> MenuItems { get; set; }

            public AdminFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<AdminFlyoutMenuItem>(new[]
                {
                    new AdminFlyoutMenuItem { Id = 0, Title = "Users",TargetType=typeof(UsersListView)},
                    new AdminFlyoutMenuItem { Id = 1, Title = "Products" },
                    new AdminFlyoutMenuItem { Id = 2, Title = "Categories" }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}