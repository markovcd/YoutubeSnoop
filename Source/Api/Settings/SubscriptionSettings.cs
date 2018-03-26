using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public sealed class SubscriptionSettings : Settings
    {
        public override RequestType RequestType => RequestType.Subscriptions;

        /// <summary>
        /// Specifies a YouTube channel ID. The API will only return that channel's subscriptions.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of the YouTube subscription ID(s) for the resource(s) that are being retrieved. In a subscription resource, the id property specifies the YouTube subscription ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of channel IDs. The API response will then only contain subscriptions matching those channels.
        /// </summary>
        public string ForChannelId { get; set; }

        /// <summary>
        /// The order parameter specifies the method that will be used to sort resources in the API response. The default value is Relevance.
        /// </summary>
        public SubscriptionOrder? Order { get; set; }
    }
}