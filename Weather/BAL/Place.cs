using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Weather.ViewModels;

namespace Weather.BAL
{
    public class Place
    {
        public static List<Weather.ViewModels.PlaceResponse> GetAllPlaces()
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.PLACEs.Select(p => new Weather.ViewModels.PlaceResponse() { place_id = p.place_id, country = p.COUNTRY.country_name, place_name = p.place_name }).ToList();
            }
        }

        public static Weather.ViewModels.PlaceResponse GetPlaceById(int placeId)
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.PLACEs
                              .Where( p => p.place_id == placeId)
                              .Select(p => new Weather.ViewModels.PlaceResponse() { place_id = p.place_id, country = p.COUNTRY.country_name, place_name = p.place_name }).SingleOrDefault();
            }
        }

        public static List<Weather.ViewModels.PlaceResponse> GetPlacesByCountry(int countryId)
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.PLACEs.Where(p => p.country_id == countryId)
                                     .Select(p => new Weather.ViewModels.PlaceResponse() { place_id = p.place_id, country = p.COUNTRY.country_name, place_name = p.place_name })
                                     .ToList();
            }
        }
    }
}