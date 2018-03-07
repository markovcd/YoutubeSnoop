using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Playlists
{
    public class Snippet
    {
        public DateTime PublishedAt { get; set; }
        public string ChannelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ChannelTitle { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public IList<string> Tags { get; set; }
        public string DefaultLanguage { get; set; }
        public TitleDescription Localized { get; set; }
    }
}