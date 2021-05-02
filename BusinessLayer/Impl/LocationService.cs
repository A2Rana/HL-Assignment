using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;
using DataAccessLayer;

namespace BusinessLayer.Impl
{
    public class LocationService : ILocationService
    {
        private ILocationRepository _locationRepo;

        public LocationService(ILocationRepository locationRepo)
        {
            _locationRepo = locationRepo;
        }

        public async Task<ICollection<LocationModel>> GetTypeAheadLocation(LocationDTO param)
        {
            try
            {
                return new List<LocationModel>(await _locationRepo.GetTypeAheadLocation(param));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
