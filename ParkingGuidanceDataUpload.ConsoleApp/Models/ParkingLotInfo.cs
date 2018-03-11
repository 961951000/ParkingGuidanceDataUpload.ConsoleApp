using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ParkingGuidanceDataUpload.ConsoleApp.Models
{
    public class ParkingLotInfo
    {
        [JsonProperty("parkId")]
        public long ParkId { get; set; }

        [JsonProperty("total")]
        public string CountCw { get; set; }

        [JsonIgnore]
        public int StopCw { get; set; }

        [JsonProperty("Surplus")]
        public int PrepCw { get; set; }
    }
}
