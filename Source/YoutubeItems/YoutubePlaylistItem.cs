using System;
using YoutubeSnoop.Entities.PlaylistItems;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using System.Linq;

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
            Item = playlistItem;
            if (Item == null) return;

            Kind = Item.Snippet.ResourceId.Kind;
            Id = Item.Snippet.ResourceId.Id();
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;
            PlaylistId = Item.Snippet.PlaylistId;
            Position = Item.Snippet.Position;

            var d = Item.Snippet.Thumbnails.ToDictionary(kv => kv.Key, kv => kv.Value);
            Thumbnails = new ReadOnlyDictionary<string, Thumbnail>(d);
        }
    }
}