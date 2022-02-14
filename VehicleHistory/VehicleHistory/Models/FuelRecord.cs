using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHistory.Models
{
    public class FuelRecord
    {
        public DateTime DateTime { get; set; }
        public string Id { get; set; }
        public int Mileage { get; set; }
        public float GallonsPumped { get; set; }

    }
}
