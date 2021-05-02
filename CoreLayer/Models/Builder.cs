using System;

namespace ModelsDTOLayer
{
    public class Builder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Phone { get; set; }
        public bool AllowUTMTracking { get; set; }
        public string State { get; set; }
        public Int16 PreferredScore { get; set; }
        public int ParentBuilderId { get; set; }
        public string CustomMortgageLink { get; set; }

    }

}
