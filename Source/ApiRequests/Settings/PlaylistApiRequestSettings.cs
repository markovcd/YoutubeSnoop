using System.Collections.Generic;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    class PlaylistApiRequestSettings : IApiRequestSettings
    {
        public ApiRequestType RequestType => ApiRequestType.PlaylistItems;

        public string PlaylistId { get; set; }
        public string PageToken { get; set; }
        public int MaxResults { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiArgument("playlistId", PlaylistId);
            yield return new ApiArgument("pageToken", PageToken);
            yield return new ApiArgument<int>("maxResults", MaxResults);
        }
    }
}
