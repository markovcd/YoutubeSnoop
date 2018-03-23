using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeSubscriptions : YoutubeCollection<YoutubeSubscription, Subscription, SubscriptionApiRequestSettings>
    {
        public YoutubeSubscriptions(IApiRequest<Subscription, SubscriptionApiRequestSettings> request) : base(request)
        {
        }
    }
}