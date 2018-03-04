using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeSearch : IYoutubeCollection<YoutubeSearchResult>
    {
        public ApiRequest<SearchResult, SearchApiRequestSettings> Request { get; }

        public YoutubeSearch(SearchApiRequestSettings settings, int resultsPerPage = 20)
        {
            Request = new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, resultsPerPage);
        }            

        public YoutubeSearch(string query)
            : this(new SearchApiRequestSettings { Query = query }) { }

        public IEnumerator<YoutubeSearchResult> GetEnumerator()
        {
            return Request.Items.Select(i => new YoutubeSearchResult(i)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}