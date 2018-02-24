using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.ApiArguments;

namespace YoutubeSnoop.ApiRequests
{
    class PlaylistApiRequest : ApiRequest
    {
        public PlaylistApiRequest(string id, string pageToken, int maxResults) : base(ApiRequestType.PlaylistItems, GetArguments(id, pageToken, maxResults).ToArray()) { }

        protected static IEnumerable<ApiArgument> GetArguments(string id, string pageToken, int maxResults)
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiPlaylistIdArgument(id);
            yield return new ApiPageTokenArgument(pageToken);
            yield return new ApiMaxResultsArgument(maxResults);
        }
    }
}
