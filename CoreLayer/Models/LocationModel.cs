using System.Runtime.Serialization;

namespace ModelsDTOLayer
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string MarketStateAbbr { get; set; }
        public string MarketStateName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool HasShowCase { get; set; }
        public string BrandType { get; set; }
        public string BrandName { get; set; }

    }
}
