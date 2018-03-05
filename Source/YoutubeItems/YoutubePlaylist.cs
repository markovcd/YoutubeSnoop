using System;
using System.Linq;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : IYoutubeItem
    {
        public IApiRequest<Playlist, PlaylistApiRequestSettings> Request { get; }
        public Playlist Item { get; }

        public string Id { get; }
        public ResourceKind Kind { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails { get; }

        public YoutubePlaylist(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : this(request.FirstItem)
        {
            Request = request;
        }

        public YoutubePlaylist(Playlist playlist)
        {
            Item = playlist;
            if (Item == null) return;

            Id = Item.Id;
            Kind = Item.Kind;
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