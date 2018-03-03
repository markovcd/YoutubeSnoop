using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeSearchResult : IYoutubeItem
    {
        public SearchResult Item { get; }
        public ResourceKind Kind { get; }
        public string Id { get; }
        public SearchResult Response { get; }

        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Response.Id.GetYoutubeItem());

        internal YoutubeSearchResult(SearchResult searchResult)
        {
            Response = searchResult;
            Kind = searchResult.Id.Kind;
            Id = searchResult.Id.GetId();       
        }
    }
}