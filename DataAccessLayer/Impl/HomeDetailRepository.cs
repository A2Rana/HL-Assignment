using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;
using RestSharp;

namespace DataAccessLayer.Impl
{
    public class HomeDetailRepository : IHomeDetailRepository
    {
        private readonly RestClient restClient;

        public HomeDetailRepository()
        {

            restClient = new RestClient("https://sprint-api.newhomesource.com/api/v2");
        }
        public async Task<List<ApiHome>> GetHomeDetails(HomeDTO param)
        {
            try
            {
                restClient.ThrowOnDeserializationError = true;

                var request = new RestRequest("Detail/Home", Method.GET, DataFormat.Json);

                request.AddObject(param);

                return await restClient.GetAsync<List<ApiHome>>(request);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
