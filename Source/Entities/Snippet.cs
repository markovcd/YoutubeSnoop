﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class Snippet : Interfaces.ITitleDescription
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public IList<string> Tags { get; set; }
        public string PlaylistId { get; set; }
        public int? Position { get; set; }
        public int? CategoryId { get; set; }
        public string LiveBroadcastContent { get; set; }
        public TitleDescription Localized { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public Interfaces.IResourceId ResourceId { get; set; }
    }

    


}
