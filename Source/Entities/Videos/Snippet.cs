using System;
using System.Collections.Generic;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Videos
{
    public class Snippet : ITitleDescription
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
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