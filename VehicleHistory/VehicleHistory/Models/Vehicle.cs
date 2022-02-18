using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHistory.Models
{
    [Serializable]
    internal class Vehicle
    {
        public string Id { get; set; }
        public HashSet<FuelRecord> FuelRecords { get; set; }
        public HashSet<Service> ServiceHistory { get; set; }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }



        [JsonConstructor]
        public Vehicle() { }


    }
}
