using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VehicleHistory.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleHistory.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FuelRecordsPage : ContentPage
    {
        FuelRecordViewModel _viewModel;
        public ObservableCollection<string> Items { get; set; }

        public FuelRecordsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new FuelRecordViewModel();
            
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
