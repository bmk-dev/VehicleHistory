using System;
using System.Collections.Generic;
using VehicleHistory.ViewModels;
using VehicleHistory.Views;
using Xamarin.Forms;

namespace VehicleHistory
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ServiceDetailPage), typeof(ServiceDetailPage));
            Routing.RegisterRoute(nameof(NewServicePage), typeof(NewServicePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
