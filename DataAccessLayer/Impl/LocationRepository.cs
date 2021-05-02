using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;
using RestSharp;

namespace DataAccessLayer.Impl
{
    public class LocationRepository : ILocationRepository
    {

        private readonly RestClient restClient;

        public LocationRepository()
        {
            restClient = new RestClient("https://sprint-api.newhomesource.com/api/v2/");
        }
        public async Task<List<LocationModel>> GetTypeAheadLocation(LocationDTO param)
        {
            try
            {
                restClient.ThrowOnDeserializationError = true;
                var request = new RestRequest("Typeahead/Locations", Method.GET, DataFormat.Json);

                request.AddParameter("partnerId", param.partnerId);

                request.AddParameter("searchTerm", param.searchTerm);

                return await restClient.GetAsync<List<LocationModel>>(request);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
