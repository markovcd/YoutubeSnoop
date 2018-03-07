using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class PlaylistItemsApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.PlaylistItems;

        public string PlaylistId { get; set; }
        public string VideoId { get; set; }
        public string Id { get; set; }
    }
}