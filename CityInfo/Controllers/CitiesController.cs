using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("/api/city")]
    public class CitiesController:Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            return new JsonResult(CityInfo.API.Entity.CityInfoContext.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {

            var CityFound = CityInfo.API.Entity.CityInfoContext.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (CityFound==null)
            {
                return NotFound();
            }

            return new JsonResult(CityInfo.API.Entity.CityInfoContext.Current.Cities.FirstOrDefault(c => c.Id == id));
        }


    }
}
