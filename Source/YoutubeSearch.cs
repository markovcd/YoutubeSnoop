using System;
using System.Collections.Generic;
using System.Text;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Settings;
using System.Linq;

namespace YoutubeSnoop
{
    public class YoutubeSearch : YoutubeCollectionRequest<SearchApiRequestSettings, Snippet, SearchResult>, IYoutubeCollection<YoutubeSearchResult, Snippet>
    {
        public IList<YoutubeSearchResult> Items => throw new NotImplementedException();

        public YoutubeSearch(SearchApiRequestSettings settings) : base(settings)
        {
            Snippets.First().
        }
    }
}
