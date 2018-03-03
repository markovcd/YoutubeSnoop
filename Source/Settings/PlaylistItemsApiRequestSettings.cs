using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class PlaylistItemsApiRequestSettings : ApiRequestSettings
    {
        public string PlaylistId { get; set; }
        public string VideoId { get; set; }
        public string Id { get; set; }

        public override RequestType RequestType => RequestType.PlaylistItems;
    }
}