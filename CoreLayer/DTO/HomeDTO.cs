using System.ComponentModel.DataAnnotations;

namespace CoreLayer.DTO
{
    public class HomeDTO
    {
        [Required]
        public int partnerId { get; set; }
        public int planId { get; set; }
        public int specId { get; set; }
        public int backFillImages { get; set; }
        public int includeBookmarks { get; set; }
        public string userId { get; set; }
        public bool? aggregateOptions { get; set; }
        public bool? includeVideoUrls { get; set; }
        public bool? includeSphericalImages { get; set; }
        public bool? setSphericalAtTheEnd { get; set; }
        public bool? includeBrandShowcase { get; set; }
        public bool? includeUrgencyData { get; set; }
        public bool? excludeHomeOptions { get; set; }
        public bool? excludeImages { get; set; }
        public bool? excludeFloorPlans { get; set; }
        public bool? excludeDescription { get; set; }
        public bool? excludeAgents { get; set; }
        public bool? excludeAmenities { get; set; }
        public bool? excludeCustomAmenities { get; set; }
        public bool? excludeUtilities { get; set; }
        public bool? excludeFeesAndTaxes { get; set; }
        public bool? excludeSummary { get; set; }
        public bool? excludeInteractiveMedia { get; set; }
        public bool? excludeSchoolDistricts { get; set; }
        public bool? excludeCommunityMap { get; set; }
        public bool? excludeTollFreeNumber { get; set; }
        public bool? excludeVideos { get; set; }
        public bool? exlucedeFloorPlanViewerUrl { get; set; }
        public bool? excludeEnvisionUrl { get; set; }
        public bool? excludeBuilderMap { get; set; }
        public bool? excludeNonPdfBrochure { get; set; }
        public bool? unPublished { get; set; }
    }
}
