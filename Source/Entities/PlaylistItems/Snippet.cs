using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.PlaylistItems
{
    public class Snippet : ITitleDescription
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public string PlaylistId { get; set; }
        public int? Position { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public IResource ResourceId { get; set; }
    }
}