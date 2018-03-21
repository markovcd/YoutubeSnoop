using System;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylistItem : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public PlaylistItem Item { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public string PlaylistId { get; }
        public int? Position { get; }
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; }

        public YoutubePlaylistItem(PlaylistItem response)
        {
            if (response == null) return;

            Item = response;
            Kind = (response.Snippet?.ResourceId?.Kind).GetValueOrDefault();
            Id = response.Snippet?.ResourceId?.Id();
            PublishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            ChannelId = response.Snippet?.ChannelId;
            Title = response.Snippet?.Title;
            Description = response.Snippet?.Description;
            ChannelTitle = response.Snippet?.ChannelTitle;
            PlaylistId = response.Snippet?.PlaylistId;
            Position = response.Snippet?.Position;
            Thumbnails = response.Snippet?.Thumbnails?.Clone();
        }
    }
}