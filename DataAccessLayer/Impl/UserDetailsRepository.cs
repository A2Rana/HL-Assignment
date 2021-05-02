using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using ModelsDTOLayer;
using ModelsDTOLayer.DTO;
using ModelsDTOLayer.Models;
using RestSharp;

namespace DataAccessLayer.Impl
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly RestClient restClient;
        public UserDetailsRepository()
        {
            restClient = new RestClient("https://sprint-api.newhomesource.com/api/v2/");
        }
        public async Task<GenericAPIModel<List<UserProfile>>> GetUserProfileDetails(UserProfileDTO param)
        {
            try
            {
                var request = new RestRequest("User/Profile", Method.GET, DataFormat.Json);

                request.AddObject(param);
                Debug.WriteLine("\n" + restClient.BuildUri(request));
                Debug.WriteLine(".................That was GET USER Profile!.........................");
                var result = await restClient.GetAsync<GenericAPIModel<List<UserProfile>>>(request);
                Debug.WriteLine("\n" + result);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<GenericAPIModel<List<BookmarkAttribute>>> GetUserBookMarkDetails(UserBookMarkDTO param)
        {
            try
            {
                var request = new RestRequest("User/Bookmarks", Method.GET, DataFormat.Json);

                request.AddObject(param);
                Debug.WriteLine("\n" + restClient.BuildUri(request));
                Debug.WriteLine(".....................That was bookmark url.........................");
                var result = await restClient.GetAsync<GenericAPIModel<List<BookmarkAttribute>>>(request);
                Debug.WriteLine("\n" + result);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<GenericAPIModel<bool>> CreateUserDetails(CreateUserDTO param)
        {
            try
            {
                var request = new RestRequest("User/Create", Method.POST, DataFormat.Json);

                request.AddJsonBody(param);

                // Debug.WriteLine("\nParams--> " + param.LogonName + " " + param.UserId);
                Debug.WriteLine(".......................That was create user params.........................");

                var result = await restClient.ExecuteAsync<GenericAPIModel<bool>>(request);

                Debug.WriteLine("\nThis is the data returned" + result.Data + " ===> " + result.Content);
                return result.Data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<GenericAPIModel<int>> CreateBookmark(BookmarkAttribute param)
        {
            try
            {
                var request = new RestRequest("User/CreateBookmark", Method.POST, DataFormat.Json);

                request.AddJsonBody(param);

                // Debug.WriteLine("\nParams--> " + param.LogonName + " " + param.UserId);
                Debug.WriteLine(".......................That was create bookmark url.........................");

                var result = await restClient.ExecuteAsync<GenericAPIModel<int>>(request);

                Debug.WriteLine("\nThis is the data returned" + result.Data + " ===> " + result.Content);

                return result.Data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<GenericAPIModel<bool>> UpdateBookmark(BookmarkAttribute param)
        {
            try
            {
                var request = new RestRequest("User/UpdateBookmark", Method.POST, DataFormat.Json);

                request.AddJsonBody(param);

                // Debug.WriteLine("\nParams--> " + param.LogonName + " " + param.UserId);
                Debug.WriteLine(".......................That was create bookmark url.........................");

                var result = await restClient.ExecuteAsync<GenericAPIModel<bool>>(request);

                Debug.WriteLine("\nThis is the data returned" + result.Data + " ===> " + result.Content);

                return result.Data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<GenericAPIModel<bool>> DeleteBookmark(int bookmarkId)
        {
            var request = new RestRequest("User/DeleteBookmark", Method.GET, DataFormat.Json);

            request.AddQueryParameter("bookmarkId", bookmarkId.ToString());

            var result = await restClient.ExecuteAsync<GenericAPIModel<bool>>(request);
            return result.Data;
        }
    }
}
