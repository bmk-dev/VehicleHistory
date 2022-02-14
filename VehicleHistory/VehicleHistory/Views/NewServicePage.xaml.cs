using System;
using System.Collections.Generic;
using System.ComponentModel;
using VehicleHistory.Models;
using VehicleHistory.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleHistory.Views
{
    public partial class NewServicePage : ContentPage
    {
        public Service Service { get; set; }

        public NewServicePage()
        {
            InitializeComponent();
            BindingContext = new NewServiceViewModel();
        }
    }
}