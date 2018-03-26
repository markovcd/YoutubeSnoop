using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeSearch : YoutubeCollection<YoutubeSearchResult, SearchResult, SearchSettings>
    {
        public YoutubeSearch(SearchSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}