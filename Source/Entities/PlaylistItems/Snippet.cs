using System;
using System.Collections.Generic;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.PlaylistItems
{
    public class Snippet
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public string PlaylistId { get; set; }
        public int? Position { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public IResource ResourceId { get; set; }
    }
}