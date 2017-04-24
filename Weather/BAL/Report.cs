using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Weather.ViewModels;

namespace Weather.BAL
{
    public class Report
    {
        public static Weather.ViewModels.ReportResponse GetTodaysWeatherByPlace(int id)
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.WEATHERs
                    .Where(w => w.place_id == id)
                    .Select(w => new Weather.ViewModels.ReportResponse() { weather_id = w.weather_id, weather_date = w.weather_date.ToString(), description = w.DESCRIPTION.description1, description_image = w.DESCRIPTION.image, max = w.max, min = w.min, place_name = w.PLACE.place_name })
                    .SingleOrDefault();
            }
        }
    }
}