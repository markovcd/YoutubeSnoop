namespace YoutubeSnoop.Api.Entities.Subscriptions
{
    public class Subscription : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the subscription.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the subscription, including its title and the channel that the user subscribed to.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object contains basic statistics about the subscription.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The subscriberSnippet object contains basic details about the subscriber.
        /// </summary>
        public SubscriberSnippet SubscriberSnippet { get; set; }
    }
}