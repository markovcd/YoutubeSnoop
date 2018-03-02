using System;

namespace YoutubeSnoop.Entities.PlaylistItems
{
    public class ContentDetails
    {
        public string VideoId { get; set; }
        public string StartAt { get; set; }
        public string EndAt { get; set; }
        public string Note { get; set; }
        public DateTime? VideoPublishedAt { get; set; }
    }
}