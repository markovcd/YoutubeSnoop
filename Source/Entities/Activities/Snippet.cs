using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Activities
{
    public class Snippet
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public string ChannelTitle { get; set; }
        public string Type { get; set; }
        public string GroupId { get; set; }
    }
}