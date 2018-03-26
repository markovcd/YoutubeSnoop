using System;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.PlaylistItems;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylistItem : IYoutubeItem
    {
        public PlaylistItem RawData { get; }
        public ResourceKind Kind { get; }
        public ResourceKind ItemKind { get; }
        public string Id { get; }
        public string ItemId { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public string PlaylistId { get; }
        public int? Position { get; }
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails { get; }
        public string Url { get; }

        public YoutubePlaylistItem(PlaylistItem response)
        {
            if (response == null) return;

            RawData = response;
            Id = response.Id;
            Kind = response.Kind;

            if (response.Snippet == null) return;

            ItemKind = (response.Snippet.ResourceId?.Kind).GetValueOrDefault();
            ItemId = response.Snippet.ResourceId?.Id();
            PublishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
            ChannelId = response.Snippet.ChannelId;
            Title = response.Snippet.Title;
            Description = response.Snippet.Description;
            ChannelTitle = response.Snippet.ChannelTitle;
            PlaylistId = response.Snippet.PlaylistId;
            Position = response.Snippet.Position;
            Thumbnails = response.Snippet.Thumbnails?.Clone();

            switch (ItemKind)
            {
                case ResourceKind.Channel: Url = YoutubeChannel.GetUrl(Id); break;
                case ResourceKind.Playlist: Url = YoutubePlaylist.GetUrl(Id); break;
                case ResourceKind.Video: Url = YoutubeVideo.GetUrl(Id); break;

                default: throw new InvalidOperationException();
            }
        }
    }
}