﻿using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Snippet : TitleDescription
    {
        public DateTime? PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string ChannelTitle { get; set; }
        public string LiveBroadcastContent { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public IList<string> Tags { get; set; }
        public string CategoryId { get; set; }
        public string DefaultLanguage { get; set; }
        public string DefaultAudioLanguage { get; set; }
        public TitleDescription Localized { get; set; }
    }
}