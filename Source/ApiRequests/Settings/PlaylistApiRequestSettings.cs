using System.Collections.Generic;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    public class PlaylistApiRequestSettings : Interfaces.IApiRequestSettings
    {
        public string PlaylistId { get; set; }
        public string VideoId { get; set; }
    
        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiArgument("playlistId", PlaylistId);
            yield return new ApiArgument("videoId", VideoId);
        }
    }
}
