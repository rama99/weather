using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Weather.BAL;
using Weather.Models;
using Weather.ViewModels;

namespace Weather.Controllers
{
    public class ReportController : ApiController
    {
        [Route("report/today/{place_id}")]
        public IHttpActionResult GetWeatherByPlace(int place_id)
        {
            return Ok(Weather.BAL.Report.GetTodaysWeatherByPlace(place_id));
        }
    }
}
