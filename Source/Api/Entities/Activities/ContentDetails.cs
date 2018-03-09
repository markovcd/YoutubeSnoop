namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ContentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public ActivityUpload Upload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem Like { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem Favorite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityPlaylistItem PlaylistItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityRecommendation Recommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem Bulletin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivitySocial Social { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityItem ChannelItem { get; set; }
    }
}