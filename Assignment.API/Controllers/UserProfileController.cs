using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using ModelsDTOLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using ModelsDTOLayer.DTO;

namespace Assignment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {

        private readonly IUserDetailsService _userDetails;
        public UserProfileController(IUserDetailsService userDetails)
        {
            _userDetails = userDetails;
        }

        [HttpGet]
        [Route("/intro")]
        public string GetBasicInfo()
        {
            return "Hey! Welcome to the user profile!";
        }

        [Route("details")]
        [HttpGet]
        public async Task<IActionResult> GetUserProfile([FromQuery] UserProfileDTO param)
        {
            try 
            { 
                return Ok(await _userDetails.GetUserProfileDetails(param)); 
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }


        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO param)
        {
            // Debug.WriteLine(param.LogonName + "\n");

            try
            {
                return Ok(await _userDetails.CreateUserDetails(param));
            }
            catch (Exception e) 
            { 
                return BadRequest(e.Message);
            }
        }

        [Route("bookmarks")]
        [HttpGet]
        public async Task<IActionResult> GetUserBookMark([FromQuery] UserBookMarkDTO param)
        {
            try
            {
                return Ok(await _userDetails.GetUserBookMarkDetails(param));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("bookmarks/create")]
        [HttpPost]
        public async Task<IActionResult> CreateBookMark([FromBody] BookmarkAttribute param)
        {
            // Debug.WriteLine(param.LogonName + "\n");

            try
            {
                return Ok(await _userDetails.CreateBookmark(param));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("bookmarks/update")]
        [HttpPost]
        public async Task<IActionResult> UpdateBookMark([FromBody] BookmarkAttribute param)
        {
            // Debug.WriteLine(param.LogonName + "\n");

            try
            {
                return Ok(await _userDetails.UpdateBookmark(param));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("bookmarks/delete")]
        [HttpGet]
        public async Task<IActionResult> DeleteBookMark([FromQuery] int bookmarkId)
        {
            try
            {
                return Ok(await _userDetails.DeleteBookmark(bookmarkId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}
