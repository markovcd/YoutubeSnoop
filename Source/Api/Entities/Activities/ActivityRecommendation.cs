namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivityRecommendation : ActivityItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IResource SeedResourceId { get; set; }
    }
}