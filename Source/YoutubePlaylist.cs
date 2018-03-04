using System;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : IYoutubeItem
    {
        public YoutubePlaylistItems Items { get; }

        public ApiRequestSingle<Playlist, PlaylistApiRequestSettings> Request { get; }

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
            if (Request.Item == null) return;

            Id = Request.Item.Id;          
            PublishedAt = Request.Item.Snippet.PublishedAt;
            ChannelId = Request.Item.Snippet.ChannelId;
            Title = Request.Item.Snippet.Title;
            Description = Request.Item.Snippet.Description;
            ChannelTitle = Request.Item.Snippet.ChannelTitle;

            Items = new YoutubePlaylistItems(Request.Item.Id);
            Url = Extensions.GetUrl(Request.Item.Kind, Request.Item.Id);
        }

        public YoutubePlaylist(Playlist playlist)
        {
            Id = playlist.Id;
            PublishedAt = playlist.Snippet.PublishedAt;
            ChannelId = playlist.Snippet.ChannelId;
            Title = playlist.Snippet.Title;
            Description = playlist.Snippet.Description;
            ChannelTitle = playlist.Snippet.ChannelTitle;

            Items = new YoutubePlaylistItems(playlist.Id);
            Url = Extensions.GetUrl(playlist.Kind, playlist.Id);
        }
    }
}