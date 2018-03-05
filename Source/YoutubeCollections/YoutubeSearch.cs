using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeSearch : IYoutubeCollection<YoutubeSearchResult>
    {
        public IApiRequest<SearchResult> Request { get; }        

        public YoutubeSearch(IApiRequest<SearchResult> request)
        {
            Request = request;
        }

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