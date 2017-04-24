﻿using System;
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
    public class DescriptionController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(Weather.BAL.Description.GetAllDescriptions());
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}