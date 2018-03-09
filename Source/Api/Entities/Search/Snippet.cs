using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Search
{
    public class Snippet : TitleDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LiveBroadcastContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }
    }
}