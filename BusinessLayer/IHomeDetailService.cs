using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;

namespace BusinessLayer
{
    public interface IHomeDetailService
    {
        Task<ICollection<ApiHome>> GetHomeDetails(HomeDTO param);
    }
}
