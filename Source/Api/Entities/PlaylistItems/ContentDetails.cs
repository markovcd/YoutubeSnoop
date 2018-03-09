using System;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class ContentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StartAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EndAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? VideoPublishedAt { get; set; }
    }
}