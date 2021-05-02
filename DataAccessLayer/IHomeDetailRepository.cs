using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;

namespace DataAccessLayer
{
    public interface IHomeDetailRepository
    {
        Task<List<ApiHome>> GetHomeDetails(HomeDTO param);
    }
}
