using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class CaptionApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Captions;


    }
}