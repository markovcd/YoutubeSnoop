using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class SubscriptionApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Subscriptions;


    }
}