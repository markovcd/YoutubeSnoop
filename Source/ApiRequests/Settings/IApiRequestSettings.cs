using System.Collections.Generic;
using System.ComponentModel;
using YoutubeSnoop.ApiRequests.Arguments;

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

    interface IApiRequestSettings
    {
        IEnumerable<ApiArgument> GetArguments();
        ApiRequestType RequestType { get; }
    }
}
