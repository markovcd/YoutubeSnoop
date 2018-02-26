using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class ChannelSnippet : Interfaces.ITitleDescription
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CustomUrl { get; set; }
        public DateTime? PublishedAt { get; set; }
        public IList<Thumbnail> Thumbnails { get; set; }
        public string DefaultLanguage { get; set; }
        public TitleDescription Localized { get; set; }
        public string Country { get; set; }
    }
}