using System;
using YoutubeSnoop.Enums;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Api.Entities;

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
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; }

        public YoutubeSearchResult(SearchResult searchResult)
        {
            if (searchResult == null) return;

            Item = searchResult;
            Kind = (searchResult.Id?.Kind).GetValueOrDefault();
            Id = searchResult.Id?.Id();           
            PublishedAt = (searchResult.Snippet?.PublishedAt).GetValueOrDefault();
            ChannelId = searchResult.Snippet?.ChannelId;
            Title = searchResult.Snippet?.Title;
            Description = searchResult.Snippet?.Description;
            ChannelTitle = searchResult.Snippet?.ChannelTitle;
            Thumbnails = searchResult.Snippet?.Thumbnails?.Clone();
        }       
    }
}