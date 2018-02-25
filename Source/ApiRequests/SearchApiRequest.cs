using YoutubeSnoop.ApiRequests.Settings;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop.ApiRequests
{
    public class SearchApiRequest : ApiRequest<SearchListResponse, SearchResult>
    {
        public SearchApiRequest(SearchApiRequestSettings settings, int maxResults = 20, string pageToken = null)
            : base(ApiRequestType.Search, maxResults, settings, pageToken) { }
    }
}
