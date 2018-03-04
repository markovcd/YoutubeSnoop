using System;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public class YoutubeSearchResult : IYoutubeItem
    {
        private IYoutubeItem _details;
        public IYoutubeItem Details => _details ?? (_details = Item.Id.GetYoutubeItem());

        public ResourceKind Kind { get; }
        public string Id { get; }
        public string Url { get; }
        public SearchResult Item { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }

        public YoutubeSearchResult(SearchResult searchResult)
        {
            Item = searchResult;

            Kind = Item.Id.Kind;
            Id = Item.Id.GetId();           
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;

            Url = Extensions.GetUrl(Item.Kind, Id);
        }
    }
}