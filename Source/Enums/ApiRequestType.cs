using System.ComponentModel;

namespace YoutubeSnoop.Enums
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