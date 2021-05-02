using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;

namespace BusinessLayer
{
    public interface ILocationService
    {
        Task<ICollection<LocationModel>> GetTypeAheadLocation(LocationDTO param);
    }
}
