using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class PlaylistItemsApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.PlaylistItems;

        /// <summary>
        /// Specifies the unique ID of the playlist for which you want to retrieve playlist items. Note that even though this is an optional parameter, every request to retrieve playlist items must specify a value for either the id parameter or the playlistId parameter.
        /// </summary>
        public string PlaylistId { get; set; }

        /// <summary>
        /// Specifies that the request should return only the playlist items that contain the specified video.
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of one or more unique playlist item IDs.
        /// </summary>
        public string Id { get; set; }
    }
}