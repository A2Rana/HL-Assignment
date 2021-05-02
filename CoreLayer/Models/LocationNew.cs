using System.Collections.Generic;

namespace ModelsDTOLayer
{
    public class LocationNew
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; } = "";
        public string MatchName { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string StateName { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public List<int> CategoryIds { get; set; }
        public string IpAddress { get; set; }
        public string Builder { get; set; }
        public bool IsNPSrp { get; set; }
        public int BuilderId { get; set; }

        //Perform task after deserialization complete from api
    }
}
