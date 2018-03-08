namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivityRecommendation : ActivityItem
    {
        public string Reason { get; set; }
        public IResource SeedResourceId { get; set; }
    }
}