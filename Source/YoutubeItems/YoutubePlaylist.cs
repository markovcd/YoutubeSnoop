using System;
using YoutubeSnoop.Entities.Playlists;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;
using System.Collections.Generic;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubePlaylist : YoutubeItem<Playlist, PlaylistApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private Playlist _item;
        private ResourceKind _kind;
        private string _channelId;
        private DateTime _publishedAt;
        private string _title;
        private string _description;
        private string _channelTitle;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;

        public Playlist Item => S(_item);
        public string Id => S(_id);
        public ResourceKind Kind => S(_kind);
        public DateTime PublishedAt => S(_publishedAt);
        public string ChannelId => S(_channelId);
        public string Title => S(_title);
        public string Description => S(_description);
        public string ChannelTitle => S(_channelTitle);
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => S(_thumbnails);

        public YoutubePlaylist(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : base(request) { }

        public YoutubePlaylist(Playlist response) : base(response) { }

        protected override void SetProperties(Playlist response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _publishedAt = response.Snippet.PublishedAt;
            _channelId = response.Snippet.ChannelId;
            _title = response.Snippet.Title;
            _description = response.Snippet.Description;
            _channelTitle = response.Snippet.ChannelTitle;
            _thumbnails = response.Snippet.Thumbnails?.Clone();     
        }
    }
}