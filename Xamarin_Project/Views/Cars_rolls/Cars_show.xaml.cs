using Xamarin_Project.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System;


namespace Xamarin_Project.Views.Cars_rolls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cars_show : ContentPage
    {
        ObservableCollection<Car> carList;
        public Cars_show()
        {

            InitializeComponent();
            
                carList = new ObservableCollection<Car>
            {
                new Car{Name="BMW I8",ImageUrl="BMWI8.jpg"},
                new Car{Name="Lamborghini Aventador LP 700-4",ImageUrl="LamborghiniAventadorLP700.jpg"},
                new Car{Name="Ferrari SF90",ImageUrl="FerrariSF90.webp"},
                new Car{Name="Nissan GT-R ",ImageUrl="nissangtrcar.webp"},
                new Car{Name="Glickenhaus 003S",ImageUrl="scuderiacameronglickenhau.jpg"},
                new Car{Name="Chevrolet Camaro",ImageUrl="chevroletcamaro.jpg"},
                new Car{Name="Ford Mustang",ImageUrl="fordmustang.jpg"},
                new Car{Name="Chevy Corvette",ImageUrl="ChevyCorvette.jpg"},
                new Car{Name="Maserati MC20",ImageUrl="novitecmaseratimc20.jpg"},
                new Car{Name="Mclaren 720s",ImageUrl="mclaren720s.jpg"}
            };
            CarCarousel.ItemsSource = carList;
        
           
        }
    }
}