using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class Snippet : TitleDescription
    {
        public DateTime? PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string ChannelTitle { get; set; }
        public string PlaylistId { get; set; }
        public int? Position { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public IResource ResourceId { get; set; }
    }
}