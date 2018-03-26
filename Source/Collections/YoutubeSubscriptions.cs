using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeSubscriptions : YoutubeCollection<YoutubeSubscription, Subscription, SubscriptionSettings>
    {
        public YoutubeSubscriptions(SubscriptionSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}