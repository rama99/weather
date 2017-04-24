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
    public class CountryController : ApiController
    {
        [Route("countries")]
        public IHttpActionResult Get()
        {
            return Ok(Weather.BAL.Country.GetAllCountries());
        }

        [Route("countries/{countryId}")]
        public IHttpActionResult GetCountryById(int countryId)
        {
            return Ok(Weather.BAL.Country.GetCountryById(countryId));
        }

        [Route("countries/{countryId}/places")]
        public IHttpActionResult GetPlacesByCountry(int countryId)
        {
            return Ok(Weather.BAL.Place.GetPlacesByCountry(countryId));
        }
    }
}
