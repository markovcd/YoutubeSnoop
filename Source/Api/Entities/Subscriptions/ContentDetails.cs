using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class ContentDetails
    {
        /// <summary>
        /// The approximate number of items that the subscription points to.
        /// </summary>
        public int? TotalItemCount { get; set; }

        /// <summary>
        /// The number of new items in the subscription since its content was last read.
        /// </summary>
        public int? NewItemCount { get; set; }

        /// <summary>
        /// The type of activity this subscription is for (only uploads, everything).
        /// </summary>
        public SubscriptionActivityType? ActivityType { get; set; }
    }
}