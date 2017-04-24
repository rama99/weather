using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.ViewModels
{
    public class ReportResponse
    {
        public int weather_id { get; set; }
        public string place_name { get; set; }
        public string weather_date { get; set; }
        public decimal min { get; set; }
        public decimal max { get; set; }
        public string description { get; set; }
        public string description_image { get; set; }

    }
}