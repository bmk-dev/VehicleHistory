using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleHistory.Models;
using VehicleHistory.ViewModels;
using VehicleHistory.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleHistory.Views
{
    public partial class ServiceHistoryPage : ContentPage
    {
        ServicesViewModel _viewModel;

        public ServiceHistoryPage()
        {
            InitializeComponent();
        
            BindingContext = _viewModel = new ServicesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}