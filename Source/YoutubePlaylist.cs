using System;
using System.Linq;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : IYoutubeItem
    {
        public IApiRequest<Playlist> Request { get; }
        public Playlist Item { get; }

        public string Id { get; }
        public DateTime PublishedAt { get; }
        public string ChannelId { get; }
        public string Title { get; }
        public string Description { get; }
        public string ChannelTitle { get; }
        
        public YoutubePlaylist(IApiRequest<Playlist> request) : this(request.FirstItem)
        {
            Request = request;
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
        }
    }
}