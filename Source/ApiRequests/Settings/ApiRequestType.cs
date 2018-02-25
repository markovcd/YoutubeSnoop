using System.ComponentModel;

namespace YoutubeSnoop.ApiRequests.Settings
{
    public enum ApiRequestType
    {
        [Description("videos")]
        Videos,
        [Description("playlistItems")]
        PlaylistItems,
        [Description("search")]
        Search
    }

}
