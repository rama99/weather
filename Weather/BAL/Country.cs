using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Weather.ViewModels;

namespace Weather.BAL
{
    public class Country
    {
        public static List<Weather.ViewModels.CountryResponse> GetAllCountries()
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.COUNTRies.Select(c => new Weather.ViewModels.CountryResponse() { country_id = c.country_id, country_name = c.country_name }).ToList();
            }
        }

        public static Weather.ViewModels.CountryResponse GetCountryById(int countryId)
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.COUNTRies.Where(c => c.country_id == countryId)
                                        .Select(c => new Weather.ViewModels.CountryResponse() { country_id = c.country_id, country_name = c.country_name }).SingleOrDefault();
            }
        }
    }
}