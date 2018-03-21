using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Playlists;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubePlaylist : YoutubeItem<Playlist, PlaylistApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private Playlist _item;
        private ResourceKind _kind;
        private string _channelId;
        private DateTime _publishedAt;
        private string _title;
        private string _description;
        private string _channelTitle;
        private IReadOnlyDictionary<ThumbnailSize, Thumbnail> _thumbnails;

        public Playlist Item => Set(ref _item);
        public string Id => Set(ref _id);
        public ResourceKind Kind => Set(ref _kind);
        public DateTime PublishedAt => Set(ref _publishedAt);
        public string ChannelId => Set(ref _channelId);
        public string Title => Set(ref _title);
        public string Description => Set(ref _description);
        public string ChannelTitle => Set(ref _channelTitle);
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails => Set(ref _thumbnails);

        public YoutubePlaylist(IApiRequest<Playlist, PlaylistApiRequestSettings> request) : base(request) { }

        public YoutubePlaylist(Playlist response) : base(response) { }

        protected override void SetProperties(Playlist response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _publishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            _channelId = response.Snippet?.ChannelId;
            _title = response.Snippet?.Title;
            _description = response.Snippet?.Description;
            _channelTitle = response.Snippet?.ChannelTitle;
            _thumbnails = response.Snippet?.Thumbnails?.Clone();     
        }
    }
}