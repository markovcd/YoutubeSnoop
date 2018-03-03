using System;
using System.Collections.Generic;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Channels
{
    public class Snippet : ITitleDescription
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CustomUrl { get; set; }
        public DateTime PublishedAt { get; set; }
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
        public string DefaultLanguage { get; set; }
        public TitleDescription Localized { get; set; }
        public string Country { get; set; }
    }
}