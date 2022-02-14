using System.ComponentModel;
using VehicleHistory.ViewModels;
using Xamarin.Forms;

namespace VehicleHistory.Views
{
    public partial class ServiceDetailPage : ContentPage
    {
        public ServiceDetailPage()
        {
            InitializeComponent();
            BindingContext = new ServiceDetailViewModel();
        }
    }
}