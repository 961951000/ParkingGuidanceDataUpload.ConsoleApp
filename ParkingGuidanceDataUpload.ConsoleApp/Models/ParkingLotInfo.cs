using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ParkingGuidanceDataUpload.ConsoleApp.Models
{
    public class ParkingLotInfo
    {
        [JsonProperty(PropertyName = "parkId")]
        public long ParkId { get; set; }

        [JsonProperty(PropertyName = "total")]
        public string CountCw { get; set; }

        [JsonIgnore]
        public int StopCw { get; set; }

        [JsonProperty(PropertyName = "Surplus")]
        public int PrepCw { get; set; }
    }
}
