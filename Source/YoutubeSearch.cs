using System;
using System.Collections.Generic;
using System.Text;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Settings;
using System.Linq;

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
