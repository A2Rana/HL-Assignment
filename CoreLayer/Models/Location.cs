using System;
using System.Collections.Generic;

namespace ModelsDTOLayer
{
    public class Location
    {
        public int Id { get; set; }
        public string CommunityNumber { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int BuilderId { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public int ParentId { get; set; }
        public int BrLo { get; set; }
        public int BrHi { get; set; }
        public int BaLo { get; set; }
        public int BaHi { get; set; }
        public int HBaLo { get; set; }
        public int HBaHi { get; set; }
        public string SftLo { get; set; }
        public string SftHi { get; set; }
        public string PrLo { get; set; }
        public string PrHi { get; set; }
        public decimal GrLow { get; set; }
        public decimal GrHi { get; set; }
        public string Addr { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string StateName { get; set; }
        public string Zip { get; set; }
        public string Thumb1 { get; set; }
        public string Thumb2 { get; set; }
        public string Thumb3 { get; set; }
        public string Status { get; set; }
        public int NumHomes { get; set; }
        public int NumQmi { get; set; }
        public int NumQmiDone { get; set; }
        public string Phone { get; set; }
        public bool IsTrackingNumber { get; set; }
        public IEnumerable<ApiAmenity> Amenities { get; set; }
        public IEnumerable<ApiSchoolDistrict> SchoolDistricts { get; set; }
        public IEnumerable<ApiSchoolDistrict> Schools { get; set; }
        public IEnumerable<BookmarkAttribute> Bookmarks { get; set; }
        public IEnumerable<ApiInteractiveMedia> IntMedia { get; set; }
        public IEnumerable<ApiImage> Images { get; set; }
        public IEnumerable<ApiVideo> Videos { get; set; }
        public List<ApiUrgencyResponse> UrgencyData { get; set; }
        public List<ApiFeesAndRates> FeesAndRates { get; set; }

    }

}
