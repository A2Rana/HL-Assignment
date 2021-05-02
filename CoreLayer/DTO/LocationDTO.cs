using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLayer.DTO
{
    public class LocationDTO
    {
        public int partnerId { get; set; }
        public string searchTerm { get; set; }
        public string types { get; set; }
        public bool includeAll { get; set; }

    }
}
