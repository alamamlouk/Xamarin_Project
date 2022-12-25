using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Project.Views.Shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mall_itemsFlyout : ContentPage
    {
        public ListView ListView;

        public Mall_itemsFlyout()
        {
            InitializeComponent();

            BindingContext = new Mall_itemsFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class Mall_itemsFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Mall_itemsFlyoutMenuItem> MenuItems { get; set; }

            public Mall_itemsFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<Mall_itemsFlyoutMenuItem>(new[]
                {
                    new Mall_itemsFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new Mall_itemsFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new Mall_itemsFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new Mall_itemsFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new Mall_itemsFlyoutMenuItem { Id = 4, Title = "Page 5" },
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