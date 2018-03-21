using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeSearch : YoutubeCollection<YoutubeSearchResult, SearchResult, SearchApiRequestSettings>
    {
        public YoutubeSearch(IApiRequest<SearchResult, SearchApiRequestSettings> request) : base(request)
        {
        }

        protected override YoutubeSearchResult CreateItem(SearchResult response)
        {
            return new YoutubeSearchResult(response);
        }
    }
}