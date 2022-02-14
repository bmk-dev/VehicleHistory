using System;
using System.Diagnostics;
using System.Threading.Tasks;
using VehicleHistory.Models;
using Xamarin.Forms;

namespace VehicleHistory.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ServiceDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string title;
        private int mileage;
        private string description;
        public string Id { get; set; }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public int Mileage
        {
            get => mileage;
            set => SetProperty(ref mileage, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await ServiceDataStore.GetItemAsync(itemId);
                Id = item.Id;
                Title = item.Title;
                Mileage = item.Mileage;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
