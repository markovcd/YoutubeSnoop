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
        private const string _playlistUrl = @"https://www.youtube.com/playlist?list={0}";

        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private DateTime _publishedAt;
        public DateTime PublishedAt => Set(ref _publishedAt);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        private string _title;
        public string Title => Set(ref _title);

        private string _description;
        public string Description => Set(ref _description);

        private string _channelTitle;
        public string ChannelTitle => Set(ref _channelTitle);

        private IReadOnlyDictionary<ThumbnailSize, Thumbnail> _thumbnails;
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails => Set(ref _thumbnails);

        private int _itemCount;
        public int ItemCount => Set(ref _itemCount);

        private string _url;
        public string Url => Set(ref _url);

        public YoutubePlaylist(Playlist response) : base(response)
        {
        }

        public YoutubePlaylist(PlaylistApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null) : base(settings, partTypes)
        {
        }

        protected override void SetProperties(Playlist response)
        {
            if (response == null) return;

            _id = response.Id;
            _kind = response.Kind;
            _url = GetUrl(response.Id);

            if (response.Snippet != null)
            {
                _publishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
                _channelId = response.Snippet.ChannelId;
                _title = response.Snippet.Title;
                _description = response.Snippet.Description;
                _channelTitle = response.Snippet.ChannelTitle;
                _thumbnails = response.Snippet.Thumbnails?.Clone();
            }

            if (response.ContentDetails != null)
            {
                _itemCount = response.ContentDetails.ItemCount.GetValueOrDefault();
            }
        }

        public static string GetUrl(string id)
        {
            return string.Format(_playlistUrl, id);
        }
    }
}