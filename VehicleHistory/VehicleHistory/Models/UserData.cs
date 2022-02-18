using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHistory.Models
{
    [Serializable]
    internal class UserData
    {
        //public List<Vehicle> UserVehicles { get; set; }

        public List<FuelRecord> FuelRecords { get; set; }
        public List<Service> ServiceHistory { get; set; } 

        [JsonConstructor]
        public UserData() { }
    }
}
