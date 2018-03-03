using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public class ChannelApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Channels;

        public string CategoryId { get; set; }
        public string ForUsername { get; set; }
        public string Hl { get; set; }
        public string Id { get; set; }
    }
}