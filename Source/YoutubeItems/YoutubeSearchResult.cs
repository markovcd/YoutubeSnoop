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
            if (searchResult == null) return;

            Item = searchResult;
            Kind = searchResult.Id.Kind;
            Id = searchResult.Id.Id();           
            PublishedAt = searchResult.Snippet.PublishedAt;
            ChannelId = searchResult.Snippet.ChannelId;
            Title = searchResult.Snippet.Title;
            Description = searchResult.Snippet.Description;
            ChannelTitle = searchResult.Snippet.ChannelTitle;
            Thumbnails = searchResult.Snippet.Thumbnails?.Clone();
        }       
    }
}