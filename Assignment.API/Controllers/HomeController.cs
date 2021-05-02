using System;
using System.Threading.Tasks;
using BusinessLayer;
using CoreLayer.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        private IHomeDetailService _homeservice;
        public HomeController (IHomeDetailService homeservice)
        {
            _homeservice = homeservice;
        }

        [HttpGet]
        [Route("homedetails")]
        public async Task<ActionResult> GetHomeDetails([FromQuery] HomeDTO param)
        {
            try
            {
                return Ok(await _homeservice.GetHomeDetails(param));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
