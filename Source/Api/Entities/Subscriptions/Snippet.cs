using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class Snippet : TitleDescription
    {
        public DateTime? PublishedAt { get; set; }
        public string ChannelTitle { get; set; }
        public IResource ResourceId { get; set; }
        public string ChannelId { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
    }
}