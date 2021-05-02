using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModelsDTOLayer;
using DataAccessLayer;
using ModelsDTOLayer.DTO;
using ModelsDTOLayer.Models;

namespace BusinessLayer
{
    public interface IUserDetailsService
    {
        Task<GenericAPIModel<List<UserProfile>>> GetUserProfileDetails(UserProfileDTO param);
        Task<GenericAPIModel<List<BookmarkAttribute>>> GetUserBookMarkDetails(UserBookMarkDTO param);
        Task<GenericAPIModel<bool>> CreateUserDetails(CreateUserDTO param);
        Task<GenericAPIModel<int>> CreateBookmark(BookmarkAttribute param);
        Task<GenericAPIModel<bool>> UpdateBookmark(BookmarkAttribute param);
        Task<GenericAPIModel<bool>> DeleteBookmark(int bookmarkID);

    }
}
