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
    public class PlaceController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(Weather.BAL.Place.GetAllPlaces());
        }

        public IHttpActionResult GetPlaceById(int placeId)
        {
            return Ok(Weather.BAL.Place.GetPlaceById(placeId));
        }
    }
}
