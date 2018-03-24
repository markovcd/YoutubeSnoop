using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeSubscriptions Subscriptions(SubscriptionSettings settings, params PartType[] partTypes)
        {
            return new YoutubeSubscriptions(settings, partTypes, ResultsPerPage);
        }

        public static YoutubeSubscription Subscription(SubscriptionSettings settings, params PartType[] partTypes)
        {
            return new YoutubeSubscription(settings, partTypes);
        }

        public static YoutubeSubscriptions Subscriptions(SubscriptionSettings settings = null)
        {
            return Subscriptions(settings, PartType.Snippet);
        }

        public static YoutubeSubscription Subscription(SubscriptionSettings settings = null)
        {
            return Subscription(settings, PartType.Snippet);
        }

        public static YoutubeSubscriptions Subscriptions(params string[] ids)
        {
            return Subscriptions(new SubscriptionSettings { Id = ids.Aggregate() });
        }

        public static YoutubeSubscription Subscription(string id)
        {
            return Subscription(new SubscriptionSettings { Id = id });
        }

        public static YoutubeSubscriptions RequestId(this YoutubeSubscriptions subscriptions, params string[] ids)
        {
            var settings = subscriptions.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return Subscriptions(settings, subscriptions.PartTypes.ToArray());
        }

        public static YoutubeSubscription RequestPart(this YoutubeSubscription subscription, PartType partType)
        {
            return Subscription(subscription.Settings.Clone(), subscription.PartTypes.Append(partType).ToArray());
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
            return Subscriptions(subscriptions.Settings.Clone(), subscriptions.PartTypes.Append(partType).ToArray());
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
            var settings = subscriptions.Settings.Clone();
            settings.ChannelId = id;
            return Subscriptions(settings, subscriptions.PartTypes.ToArray());
        }

        public static YoutubeSubscriptions OrderBy(this YoutubeSubscriptions subscriptions, SubscriptionOrder order)
        {
            var settings = subscriptions.Settings.Clone();
            settings.Order = order;
            return Subscriptions(settings, subscriptions.PartTypes.ToArray());
        }

        public static YoutubeSubscriptions OrderByName(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.OrderBy(SubscriptionOrder.Alphabetical);
        }

        public static YoutubeSubscriptions OrderByRelevance(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.OrderBy(SubscriptionOrder.Relevance);
        }

        public static YoutubeSubscriptions OrderByUnread(this YoutubeSubscriptions subscriptions)
        {
            return subscriptions.OrderBy(SubscriptionOrder.Unread);
        }
    }
}