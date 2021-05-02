using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class UserProfileDTO
    {
        [Required]
        public string userID { get; set; }
        public string logonName { get; set; }
        [Required]
        public string partnerId { get; set; }
        public int orgId { get; set; }
        [DefaultValue(false)]
        public bool returnPassword { get; set; }
        [DefaultValue(false)]
        public bool showBookmarks { get; set; }
        [DefaultValue(false)]
        public bool showSharedUsers { get; set; }
        [DefaultValue(false)]
        public bool getLinkedUser { get; set; }
        [DefaultValue(false)]
        public bool showBoards { get; set; }
        
    }
}
