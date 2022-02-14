using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using VehicleHistory.Models;
using VehicleHistory.Services;
using VehicleHistory.Views;
using Xamarin.Forms;

namespace VehicleHistory.ViewModels
{
    public class FuelRecordViewModel : BaseViewModel
    {
        private FuelRecord _selectedItem;

        public ObservableCollection<FuelRecord> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<FuelRecord> ItemTapped { get; }

        public FuelRecordViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<FuelRecord>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<FuelRecord>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await FuelRecordDataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public FuelRecord SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewServicePage));
        }

        async void OnItemSelected(FuelRecord item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ServiceDetailPage)}?{nameof(ServiceDetailViewModel.ItemId)}={item.Id}");
        }
    }
}