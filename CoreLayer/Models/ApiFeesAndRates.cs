using System;

namespace ModelsDTOLayer
{
    public class ApiFeesAndRates
    {
        public string Description { get; set; }
        public string TypeCode { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal YearlyFee { get; set; }
        public int CommunityId { get; set; }

    }

}
