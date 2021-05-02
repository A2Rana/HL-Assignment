using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.DTO;
using ModelsDTOLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class HomeDetailService : IHomeDetailService
    {
        private readonly IHomeDetailRepository _homedetails;

        public HomeDetailService(IHomeDetailRepository homedetails)
        {
            _homedetails = homedetails;
        }

        public async Task<ICollection<ApiHome>> GetHomeDetails(HomeDTO param)
        {
            try
            {
                return await _homedetails.GetHomeDetails(param);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
