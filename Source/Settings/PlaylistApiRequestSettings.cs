using System.Collections.Generic;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Settings
{
    public class PlaylistApiRequestSettings : IApiRequestSettings
    {
        public string PlaylistId { get; set; }
        public string VideoId { get; set; }

        public ApiRequestType RequestType => ApiRequestType.PlaylistItems;

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiArgument("playlistId", PlaylistId);
            yield return new ApiArgument("videoId", VideoId);
        }
    }
}