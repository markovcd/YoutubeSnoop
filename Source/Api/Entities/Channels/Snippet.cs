using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Snippet : TitleDescription
    {
        public string CustomUrl { get; set; }
        public DateTime? PublishedAt { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public string DefaultLanguage { get; set; }
        public TitleDescription Localized { get; set; }
        public string Country { get; set; }
    }
}