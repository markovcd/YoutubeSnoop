using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeSearch : YoutubeCollectionRequest<SearchApiRequestSettings, SearchResult>, IYoutubeCollection<YoutubeSearchResult>
    {
        public IList<YoutubeSearchResult> Items { get; }

        public YoutubeSearch(SearchApiRequestSettings settings) : base(settings)
        {
            Items = Responses.Select(i => new YoutubeSearchResult(i)).ToList();
        }

        public YoutubeSearch(string query)
            : base(new SearchApiRequestSettings { Query = query }) { }
    }
}