namespace ModelsDTOLayer.DTO
{
    public class UserBookMarkDTO
    {
        public string UserId { get; set; }
        public string LogonName { get; set; }
        public string PartnerId { get; set; }
        public bool? ShowNotes { get; set; }
        public bool? ShowSharedUsers { get; set; }
        public bool? ShowSharedBookmarks { get; set; }
        public bool? GetLastElement { get; set; }
        public BookmarkActionType? actionName { get; set; }
        public int? ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
    }
}
