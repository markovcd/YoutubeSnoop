using System;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : YoutubeRequest<PlaylistApiRequestSettings, Playlist>, IYoutubeItem
    {
        private YoutubePlaylistItems _items;
        public YoutubePlaylistItems Items => _items ?? (_items = new YoutubePlaylistItems(Id));

        public string Url { get; }
        public string Id { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }

        public YoutubePlaylist(string id)
            : this(new PlaylistApiRequestSettings { Id = id }) { }

        public YoutubePlaylist(PlaylistApiRequestSettings settings) : base(settings)
        {
            Id = Response.Id;
            Url = Extensions.GetUrl(Response.Kind, Response.Id);
            PublishedAt = Response.Snippet.PublishedAt;
            ChannelId = Response.Snippet.ChannelId;
            Title = Response.Snippet.Title;
            Description = Response.Snippet.Description;
            ChannelTitle = Response.Snippet.ChannelTitle;
        }
    }
}