using System;

namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Snippet
    {
        /// <summary>
        /// 
        /// </summary>
        public string AuthorDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AuthorProfileImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AuthorChannelUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PropertyValue AuthorChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TextDisplay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? LikeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}