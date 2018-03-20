using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Activities
{
    public class ActivityRecommendation : ActivityItem
    {
        /// <summary>
        /// The reason that the resource is recommended to the user.
        /// </summary>
        public RecommendationReason? Reason { get; set; }

        /// <summary>
        /// The seedResourceId object contains information about the resource that caused the recommendation.
        /// </summary>
        public Resource SeedResourceId { get; set; }
    }
}