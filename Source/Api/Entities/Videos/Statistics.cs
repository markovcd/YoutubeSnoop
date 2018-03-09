namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Statistics
    {
        /// <summary>
        /// The number of times the video has been viewed.
        /// </summary>
        public long? ViewCount { get; set; }

        /// <summary>
        /// The number of users who have indicated that they liked the video.
        /// </summary>
        public long? LikeCount { get; set; }

        /// <summary>
        /// The number of users who have indicated that they disliked the video.
        /// </summary>
        public long? DislikeCount { get; set; }

        /// <summary>
        /// The number of comments for the video.
        /// </summary>
        public long? CommentCount { get; set; }
    }
}