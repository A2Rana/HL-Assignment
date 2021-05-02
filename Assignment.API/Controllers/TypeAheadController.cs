using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using BusinessLayer;
using CoreLayer.DTO;
using Microsoft.AspNetCore.Mvc;
using ModelsDTOLayer;

namespace Assignment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeAheadController : ControllerBase
    {
        private ILocationService _locationService;

        public TypeAheadController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [Route("/basic")]
        [HttpGet]
        public string GetLocations()
        {
            return "Hey! Austin or Dallas?";
        }

        [Route("locations")]
        [HttpGet]
        public async Task<IActionResult> GetTypeAheadHandler([FromQuery] LocationDTO param)
        {
            /*int partnerId = Convert.ToInt32((string)HttpContext.Request.Query["partnerId"]);
            string searchTerm = (string)HttpContext.Request.Query["searchTerm"];
            string types = (string)HttpContext.Request.Query["types"];
            bool includeAll = Convert.ToBoolean((string)HttpContext.Request.Query["types"]);*/
            try
            {
                Console.WriteLine(param);
                ICollection<LocationModel> response = await _locationService.GetTypeAheadLocation(param);

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
