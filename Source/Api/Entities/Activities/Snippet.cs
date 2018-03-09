using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Activities
{
    public class Snippet
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
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IDictionary<string, Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GroupId { get; set; }
    }
}