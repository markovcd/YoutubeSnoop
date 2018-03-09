using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
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
        public string PlaylistId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IResource ResourceId { get; set; }
    }
}