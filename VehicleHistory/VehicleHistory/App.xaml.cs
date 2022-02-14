using System;
using VehicleHistory.Services;
using VehicleHistory.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleHistory
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<ServiceDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
