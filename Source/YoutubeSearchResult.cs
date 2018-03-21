using System;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Search;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeSearchResult : IYoutubeItem
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

        public YoutubeSearchResult(SearchResult response)
        {
            if (response == null) return;

            Item = response;
            Kind = (response.Id?.Kind).GetValueOrDefault();
            Id = response.Id?.Id();
            PublishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            ChannelId = response.Snippet?.ChannelId;
            Title = response.Snippet?.Title;
            Description = response.Snippet?.Description;
            ChannelTitle = response.Snippet?.ChannelTitle;
            Thumbnails = response.Snippet?.Thumbnails?.Clone();
        }
    }
}