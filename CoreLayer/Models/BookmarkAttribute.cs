using System;
using System.Collections.Generic;

namespace ModelsDTOLayer
{
    public class BookmarkAttribute
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public Int16 ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public Int64 ContentId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public BookmarkActionType Action { get; set; }
        public IList<UserProfile> SharedUsers { get; set; }
        public List<BookmarkData> BookmarkData { get; set; }

    }

}
