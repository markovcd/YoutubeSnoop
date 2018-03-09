using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public string CustomUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TitleDescription Localized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }
    }
}