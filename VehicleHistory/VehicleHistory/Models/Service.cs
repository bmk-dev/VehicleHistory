using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VehicleHistory.Models
{
    [Serializable]
    public class Service
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }

        public List<Part> Parts { get; set; }




        [JsonConstructor]
        public Service()
        {

        }
    }
}