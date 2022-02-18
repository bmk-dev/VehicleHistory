using System;
using System.Windows.Input;
using VehicleHistory.IO;
using VehicleHistory.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VehicleHistory.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public float LastTankMPG { get; set; }
        public float LifetimeMPG { get; set; }
        public HomeViewModel()
        {
            Title = "Home";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public void SwitchTab()
        {

        }

        

        public ICommand OpenWebCommand { get; }



    }
}