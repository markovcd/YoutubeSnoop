using System;

namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Snippet
    {
        public string AuthorDisplayName { get; set; }
        public string AuthorProfileImageUrl { get; set; }
        public string AuthorChannelUrl { get; set; }
        public PropertyValue AuthorChannelId { get; set; }
        public string ChannelId { get; set; }
        public string VideoId { get; set; }
        public string TextDisplay { get; set; }
        public string TextOriginal { get; set; }
        public string ParentId { get; set; }
        public bool? CanRate { get; set; }
        public string ViewerRating { get; set; }
        public int? LikeCount { get; set; }
        public string ModerationStatus { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}