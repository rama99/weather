using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Weather.ViewModels;

namespace Weather.BAL
{
    public class Description
    {
        public static List<Weather.ViewModels.DescriptionResponse> GetAllDescriptions()
        {
            using (Weather.Models.DB_WEATHEREntities context = new Models.DB_WEATHEREntities())
            {
                return context.DESCRIPTIONs.Select(d => new Weather.ViewModels.DescriptionResponse() { description = d.description1, description_id = d.description_id, image = d.image }).ToList();
            }
        }        
    }
}