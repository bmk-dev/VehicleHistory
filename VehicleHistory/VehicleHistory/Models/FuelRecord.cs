using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHistory.Models
{
    [Serializable]
    public class FuelRecord
    {
        public string Id { get; set; }

        // The mileage when pumped
        public int Mileage { get; set; }

        // Number of gallons pumped
        public float GallonsPumped { get; set; }


        [JsonConstructor]
        public FuelRecord()
        {

        }

    }
}
