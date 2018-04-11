using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("/api/cities")]
    public class CitiesController:Controller
    {
        [HttpGet("{id}")]
        public JsonResult GetCities()
        {
           return new JsonResult()
            
        }


    }
}
