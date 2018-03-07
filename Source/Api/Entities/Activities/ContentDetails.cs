namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ContentDetails
    {
        public Upload Upload { get; set; }
        public ActivityItem Like { get; set; }
        public ActivityItem Favorite { get; set; }
        public ActivityItem Comment { get; set; }
        public ActivityItem Subscription { get; set; }
        public PlaylistActivityItem PlaylistItem { get; set; }
        public ActivityItem Recommendation { get; set; }
        public ActivityItem Bulletin { get; set; }
        public Social Social { get; set; }
        public ActivityItem ChannelItem { get; set; }
    }
}