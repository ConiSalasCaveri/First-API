using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace CityInfo.Controllers
{
    [Route("/api/city")]
    public class TuristicPointController : Controller
    {
        private ILogger<TuristicPointController> _logger;
        public TuristicPointController(ILogger<TuristicPointController> logger)
        {
            _logger = logger;
        }


        [HttpGet("{cityId}/turisticpoints")]
        public IActionResult GetTuristicPoints(int cityId)
        {
            // _logger.LogInformation("Un ejemplo");

            var CityCurrent = CityInfo.API.Entity.CityInfoContext.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (CityCurrent == null)
            {
                return NotFound();
            }

            return Ok(CityCurrent.TuristicPoints);
        }


        [HttpGet("{cityId}/turisticpoints/{id}", Name ="GetTuristicPoint")]
        public IActionResult GetSpecificTuristicPoint(int cityId, int id)
        {
            var CityCurrent = CityInfo.API.Entity.CityInfoContext.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            var TuristicPointCurrent = CityCurrent.TuristicPoints.FirstOrDefault(c => c.Id == id);

            if (CityCurrent == null)
            {
                return NotFound();
            }

            if (TuristicPointCurrent == null)
            {
                return NotFound();
            }

            return Ok(TuristicPointCurrent);
        }

        [HttpPost("{cityId}/turisticpoints")]
        public IActionResult CreateTuristicPoint(int cityId,
            [FromBody] CityInfo.Models.TuristicPointDto turisticPoint)
            //contiene los datos para la creacion del nuevo turistic point, para luego deserializarlo
        {
            if (turisticPoint == null)
            {
                return BadRequest();
            }

            var CityCurrent = CityInfo.API.Entity.CityInfoContext.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (CityCurrent == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var turisticPointToCreate = new API.Entity.TuristicPoint()
            {
                Id = 12,
                Description = turisticPoint.Description,
                Name = turisticPoint.Name
            };

            CityCurrent.TuristicPoints.Add(turisticPointToCreate);

            return CreatedAtRoute("GetTuristicPoint", new { cityId = CityCurrent.Id, id = turisticPointToCreate.Id }, turisticPointToCreate);

        }


    }
}
