using System;
using System.Collections.Generic;
using System.Text;
using YoutubeSnoop.ApiRequests.Arguments;

namespace YoutubeSnoop.ApiRequests.Settings
{
    class SearchApiRequestSettings : IApiRequestSettings
    {
        public ApiRequestType RequestType => ApiRequestType.Search;

        public string Id { get; set; }
        public string PageToken { get; set; }
        public int MaxResults { get; set; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            yield return new ApiPartArgument(PartType.Snippet);
            yield return new ApiPlaylistIdArgument(Id);
            yield return new ApiPageTokenArgument(PageToken);
            yield return new ApiMaxResultsArgument(MaxResults);
        }
    }
}
