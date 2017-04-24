using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.ViewModels
{
    public class DescriptionResponse
    {
        public int description_id { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }
}