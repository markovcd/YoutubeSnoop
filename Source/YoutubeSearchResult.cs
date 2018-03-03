using System;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeSearchResult : IYoutubeItem
    {
        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Response.Id.GetYoutubeItem());

        public ResourceKind Kind { get; }
        public string Id { get; }
        public SearchResult Response { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
       
        internal YoutubeSearchResult(SearchResult searchResult)
        {
            Response = searchResult;
            Kind = searchResult.Id.Kind;
            Id = searchResult.Id.GetId();
            PublishedAt = searchResult.Snippet.PublishedAt;
            ChannelId = searchResult.Snippet.ChannelId;
            Title = searchResult.Snippet.Title;
            Description = searchResult.Snippet.Description;
            ChannelTitle = searchResult.Snippet.ChannelTitle;
        }
    }
}