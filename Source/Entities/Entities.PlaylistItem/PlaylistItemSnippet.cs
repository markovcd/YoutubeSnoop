using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YoutubeSnoop.Converters;

namespace YoutubeSnoop.Entities
{
    public class PlaylistItemSnippet : Interfaces.ITitleDescription
    {
        public DateTime? PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public string PlaylistId { get; set; }
        public int? Position { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public Interfaces.IResource ResourceId { get; set; }
    }
}