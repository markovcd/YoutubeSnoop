namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ContentDetails
    {
        /// <summary>
        /// The upload object contains information about the uploaded video. This property is only present if the snippet.type is upload.
        /// </summary>
        public ActivityUpload Upload { get; set; }

        /// <summary>
        /// The like object contains information about a resource that received a positive (like) rating. This property is only present if the snippet.type is like.
        /// </summary>
        public ActivityItem Like { get; set; }

        /// <summary>
        /// The favorite object contains information about a video that was marked as a favorite video. This property is only present if the snippet.type is favorite.
        /// </summary>
        public ActivityItem Favorite { get; set; }

        /// <summary>
        /// The comment object contains information about a resource that received a comment. This property is only present if the snippet.type is comment.
        /// </summary>
        public ActivityItem Comment { get; set; }

        /// <summary>
        /// The subscription object contains information about a channel that a user subscribed to. This property is only present if the snippet.type is subscription.
        /// </summary>
        public ActivityItem Subscription { get; set; }

        /// <summary>
        /// The playlistItem object contains information about a new playlist item. This property is only present if the snippet.type is playlistItem.
        /// </summary>
        public ActivityPlaylistItem PlaylistItem { get; set; }

        /// <summary>
        /// The recommendation object contains information about a recommended resource. This property is only present if the snippet.type is recommendation.
        /// </summary>
        public ActivityRecommendation Recommendation { get; set; }

        /// <summary>
        /// The bulletin object contains details about a channel bulletin post. This object is only present if the snippet.type is bulletin.
        /// </summary>
        public ActivityItem Bulletin { get; set; }

        /// <summary>
        /// The social object contains details about a social network post. This property is only present if the snippet.type is social.
        /// </summary>
        public ActivitySocial Social { get; set; }

        /// <summary>
        /// The channelItem object contains details about a resource that was added to a channel. This property is only present if the snippet.type is channelItem.
        /// </summary>
        public ActivityItem ChannelItem { get; set; }
    }
}