//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEATHER
    {
        public int weather_id { get; set; }
        public int place_id { get; set; }
        public System.DateTimeOffset weather_date { get; set; }
        public decimal min { get; set; }
        public decimal max { get; set; }
        public int description_id { get; set; }
    
        public virtual DESCRIPTION DESCRIPTION { get; set; }
        public virtual PLACE PLACE { get; set; }
    }
}