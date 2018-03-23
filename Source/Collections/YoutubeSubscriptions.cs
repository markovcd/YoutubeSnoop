using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeSubscriptions : YoutubeCollection<YoutubeSubscription, Subscription, SubscriptionApiRequestSettings>
    {
        public YoutubeSubscriptions(IApiRequest<Subscription, SubscriptionApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeSubscriptions(SubscriptionApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}