using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModelsDTOLayer;
using DataAccessLayer;
using ModelsDTOLayer.DTO;
using ModelsDTOLayer.Models;

namespace BusinessLayer.Impl
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetails;
        public UserDetailsService(IUserDetailsRepository userDetails)
        {
            _userDetails = userDetails;
        }
        public async Task<GenericAPIModel<List<UserProfile>>> GetUserProfileDetails(UserProfileDTO param)
        {
            try
            {
                return await _userDetails.GetUserProfileDetails(param);
            }
            catch (Exception e) { throw e; }
        }

        public async Task<GenericAPIModel<List<BookmarkAttribute>>> GetUserBookMarkDetails(UserBookMarkDTO param)
        {
            try
            {
                return await _userDetails.GetUserBookMarkDetails(param);
            }
            catch (Exception e) { throw e; }
        }

        public async Task<GenericAPIModel<bool>> CreateUserDetails(CreateUserDTO param)
        {
            try
            {
                return await _userDetails.CreateUserDetails(param);
            }
            catch (Exception e) { throw e; }
        }

        public async Task<GenericAPIModel<int>> CreateBookmark(BookmarkAttribute param)
        {
            try
            {
                return await _userDetails.CreateBookmark(param);
            }
            catch (Exception e) { throw e; }
        }

        public async Task<GenericAPIModel<bool>> UpdateBookmark(BookmarkAttribute param)
        {
            try
            {
                return await _userDetails.UpdateBookmark(param);
            }
            catch (Exception e) { throw e; }
        }

        public async Task<GenericAPIModel<bool>> DeleteBookmark(int bookmarkID)
        {
            try
            {
                return await _userDetails.DeleteBookmark(bookmarkID);
            }
            catch (Exception e) { throw e; }
        }
    }
}
