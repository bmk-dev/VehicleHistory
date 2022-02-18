using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleHistory.Models
{
    [Serializable]
    public class Part
    {
        public string PartNumber { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
}
