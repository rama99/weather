using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.ViewModels
{
    public class PlaceResponse
    {
        public int place_id { get; set; }
        public string place_name { get; set; }
        public string country { get; set; }
    }
}