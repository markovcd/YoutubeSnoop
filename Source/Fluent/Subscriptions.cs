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
            var request = GetDefaultRequest<Subscription, SubscriptionApiRequestSettings>(settings, partTypes);
            return new YoutubeSubscriptions(request);
        }

        public static YoutubeSubscription Subscription(SubscriptionApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = GetDefaultRequest<Subscription, SubscriptionApiRequestSettings>(settings, partTypes);
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

        public static YoutubeSubscriptions Subscriptions(params string[] ids)
        {
            return Subscriptions(new SubscriptionApiRequestSettings { Id = ids.Aggregate((s1, s2) => $"{s1},{s2}") });
        }

        public static YoutubeSubscription Subscription(string id)
        {
            return Subscription(new SubscriptionApiRequestSettings { Id = id });
        }

        public static YoutubeSubscriptions RequestId(this YoutubeSubscriptions subscriptions, params string[] ids)
        {
            var request = subscriptions.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeSubscriptions(request);
        }

        public static YoutubeSubscription RequestPart(this YoutubeSubscription subscription, PartType partType)
        {
            var request = subscription.Request.RequestPart(partType);
            return new YoutubeSubscription(request);
        }

        public static YoutubeSubscription RequestContentDetails(this YoutubeSubscription subscription)
        {
            return subscription.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeSubscription RequestSubscriberSnippet(this YoutubeSubscription subscription)
        {
            return subscription.RequestPart(PartType.SubscriberSnippet);
        }

        public static YoutubeSubscription RequestSnippet(this YoutubeSubscription subscription)
        {
            return subscription.RequestPart(PartType.Snippet);
        }

        public static YoutubeSubscription RequestAllParts(this YoutubeSubscription subscription)
        {
            return subscription.RequestContentDetails().RequestSubscriberSnippet().RequestSnippet();
        }

        public static YoutubeSubscriptions RequestPart(this YoutubeSubscriptions subscriptions, PartType partType)
        {
            var request = subscriptions.Request.RequestPart(partType);
            return new YoutubeSubscriptions(request);
        }

        public static YoutubeSubscriptions RequestContentDetails(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.RequestPart(PartType.ContentDetails);
        }

        public static YoutubeSubscriptions RequestSubscriberSnippet(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.RequestPart(PartType.SubscriberSnippet);
        }

        public static YoutubeSubscriptions RequestSnippet(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.RequestPart(PartType.Snippet);
        }

        public static YoutubeSubscriptions RequestAllParts(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.RequestContentDetails().RequestSubscriberSnippet().RequestSnippet();
        }

        public static YoutubeSubscriptions ForChannelId(this YoutubeSubscriptions subscriptions, string id)
        {
            var request = subscriptions.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeSubscriptions(request);
        }

        public static YoutubeSubscriptions OrderBy(this YoutubeSubscriptions subscriptions, SubscriptionOrder order)
        {
            var request = subscriptions.Request.Clone();
            request.Settings.Order = order;
            return new YoutubeSubscriptions(request);
        }
    }
}