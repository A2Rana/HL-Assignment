using System.Collections.Generic;
using System.Linq;
using GraphQL;
using RestSharp;
using System.Diagnostics;
using System.Threading.Tasks;
using ModelsDTOLayer;
using DataAccessLayer;
using DataAccessLayer.Impl;

namespace GraphQLLib    
{
    public class Query
    {

        [GraphQLMetadata("locations")]
        public Task<List<LocationModel>> GetLocations(int partnerId, string searchTerm)
        {

            LocationRepository _locationRepo = new LocationRepository();

            return _locationRepo.GetTypeAheadLocation(new CoreLayer.DTO.LocationDTO()
            {
                partnerId = partnerId,
                searchTerm = searchTerm
            });
            
        }


        [GraphQLMetadata("homedetails")]
        public Task<List<ApiHome>> GetHomeDetails(int partnerId, int planId)
        {

            HomeDetailRepository _homeRepo = new HomeDetailRepository();

            return _homeRepo.GetHomeDetails(new CoreLayer.DTO.HomeDTO()
            {
                partnerId = partnerId,
                planId = planId
            });

        }



        [GraphQLMetadata("checkLocationInput")]
        public string GetCheckLocationInput(int partnerId, string searchTerm)
        {
            return "Input parameters are: " + partnerId + " " + searchTerm;
        }

        [GraphQLMetadata("checkHomeInput")]
        public string GetCheckHomeInput(int partnerId, int planId)
        {
            return "Input parameters are: " + partnerId + " and " + planId;
        }

        

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return " Hey! Hello World";
        }

        [GraphQLMetadata("pello")]
        public string GetPello()
        {
            return "This is pello text!";
        }
    }
}
