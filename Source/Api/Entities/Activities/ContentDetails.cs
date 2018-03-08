namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ContentDetails
    {
        public ActivityUpload Upload { get; set; }
        public ActivityItem Like { get; set; }
        public ActivityItem Favorite { get; set; }
        public ActivityItem Comment { get; set; }
        public ActivityItem Subscription { get; set; }
        public ActivityPlaylistItem PlaylistItem { get; set; }
        public ActivityRecommendation Recommendation { get; set; }
        public ActivityItem Bulletin { get; set; }
        public ActivitySocial Social { get; set; }
        public ActivityItem ChannelItem { get; set; }
    }
}