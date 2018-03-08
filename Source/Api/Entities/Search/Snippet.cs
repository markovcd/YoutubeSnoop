using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Search
{
    public class Snippet : TitleDescription
    {
        public DateTime? PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string ChannelTitle { get; set; }
        public string LiveBroadcastContent { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
    }
}