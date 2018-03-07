using System;
using YoutubeSnoop.Enums;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop
{
    public class YoutubePlaylistItem : IYoutubeItem
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
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails { get; }

        public YoutubePlaylistItem(PlaylistItem playlistItem)
        {
            if (playlistItem == null) return;

            Item = playlistItem;
            Kind = playlistItem.Snippet.ResourceId.Kind;
            Id = playlistItem.Snippet.ResourceId?.Id();
            PublishedAt = playlistItem.Snippet.PublishedAt;
            ChannelId = playlistItem.Snippet.ChannelId;
            Title = playlistItem.Snippet.Title;
            Description = playlistItem.Snippet.Description;
            ChannelTitle = playlistItem.Snippet.ChannelTitle;
            PlaylistId = playlistItem.Snippet.PlaylistId;
            Position = playlistItem.Snippet.Position;
            Thumbnails = playlistItem.Snippet.Thumbnails?.Clone();
        }
    }
}