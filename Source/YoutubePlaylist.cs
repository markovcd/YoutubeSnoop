using System;
using System.Linq;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : IYoutubeItem
    {
        public YoutubePlaylistItems Items { get; }

        public IApiRequest<Playlist> Request { get; }
        public Playlist Item { get; }

        public string Url { get; }
        public string Id { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }

        public YoutubePlaylist(string id)
            : this(new PlaylistApiRequestSettings { Id = id }) { }

        public YoutubePlaylist(PlaylistApiRequestSettings settings)
        {
            Request = new ApiRequestSingle<Playlist, PlaylistApiRequestSettings>(settings);
            Item = Request.Items.FirstOrDefault();
            if (Item == null) return;

            Id = Item.Id;          
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;

            Items = new YoutubePlaylistItems(Item.Id);
            Url = Extensions.GetUrl(Item.Kind, Item.Id);
        }

        public YoutubePlaylist(Playlist playlist)
        {
            Item = playlist;
            if (Item == null) return;

            Id = Item.Id;
            PublishedAt = Item.Snippet.PublishedAt;
            ChannelId = Item.Snippet.ChannelId;
            Title = Item.Snippet.Title;
            Description = Item.Snippet.Description;
            ChannelTitle = Item.Snippet.ChannelTitle;

            Items = new YoutubePlaylistItems(Item.Id);
            Url = Extensions.GetUrl(Item.Kind, Item.Id);
        }
    }
}