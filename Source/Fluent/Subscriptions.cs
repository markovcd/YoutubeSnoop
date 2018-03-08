using System.Linq;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeSubscriptions Subscriptions(SubscriptionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Subscription, SubscriptionApiRequestSettings>(settings, partTypes);
            return new YoutubeSubscriptions(request);
        }

        public static YoutubeSubscription Subscription(SubscriptionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Subscription, SubscriptionApiRequestSettings>(settings, partTypes);
            return new YoutubeSubscription(request);
        }

        public static YoutubeSubscriptions Subscriptions(SubscriptionApiRequestSettings settings = null)
        {
            return Subscriptions(settings ?? new SubscriptionApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeSubscription Subscription(SubscriptionApiRequestSettings settings = null)
        {
            return Subscription(settings ?? new SubscriptionApiRequestSettings(), PartType.Snippet);
        }
    }
}
