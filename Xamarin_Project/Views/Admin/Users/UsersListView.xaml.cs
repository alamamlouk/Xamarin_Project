using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin_Project.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Project.Services;
using System.Collections.Generic;


namespace Xamarin_Project.Views.Admin.Users
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersListView : ContentPage
    { 
        
        public ObservableCollection<User> Items { get; set; }

        public UsersListView()
        {
            InitializeComponent();
            intiList();
            

        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

           
            ((ListView)sender).SelectedItem = null;
        }
        public async void intiList()
        {
            MyListView.ItemsSource=null;
            List<User> users = (List<User>) await App.UserServices.GetUsers();
            Items = new ObservableCollection<User> { };
            foreach(User u in users)
            {
                Items.Add(u);
            }
            
            MyListView.ItemsSource = Items;
            
        }
        public async void UpdateUser(Object sender, EventArgs e)
        {
            var menuItem = sender as Button;
            int currentItem = int.Parse(menuItem.CommandParameter.ToString());
            User u = await App.UserServices.GetUserById(currentItem);
            Console.WriteLine(u.Name);
            await Navigation.PushAsync(new UpdateUser(u));
        }
        public async void DeleteUser(Object sender,EventArgs e)
        {
            var menuItem = sender as Button;
            int currentItem = int.Parse(menuItem.CommandParameter.ToString());
            await App.UserServices.DeleteUSer(currentItem);
            intiList();
            
        }

    }
}
