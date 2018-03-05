using System;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using System.Linq;

namespace YoutubeSnoop
{
    public class YoutubeSearchResult : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public SearchResult Item { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails { get; }

        public YoutubeSearchResult(SearchResult searchResult)
        {
            Item = searchResult;

            Kind = Item.Id.Kind;
            Id = Item.Id.Id();           
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;

            var d = Item.Snippet.Thumbnails.ToDictionary(kv => kv.Key, kv => kv.Value);
            Thumbnails = new ReadOnlyDictionary<string, Thumbnail>(d);
        }
    }
}