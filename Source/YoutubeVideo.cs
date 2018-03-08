using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api;

namespace YoutubeSnoop
{
    public class YoutubeVideo : YoutubeItem<Video, VideoApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private Video _item;
        private ResourceKind _kind;
        private string _channelId;
        private DateTime _publishedAt;
        private string _title;
        private string _description;
        private string _channelTitle;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;
        private int _categoryId;

        public Video Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public DateTime PublishedAt => S(ref _publishedAt);
        public string ChannelId => S(ref _channelId);
        public string Title => S(ref _title);
        public string Description => S(ref _description);
        public string ChannelTitle => S(ref _channelTitle);
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => S(ref _thumbnails);

        public YoutubeVideo(IApiRequest<Video, VideoApiRequestSettings> request) : base(request) { }

        public YoutubeVideo(Video response) : base(response) { }

        protected override void SetProperties(Video response)
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
            int.TryParse(response.Snippet?.CategoryId, out _categoryId);
            _thumbnails = response.Snippet?.Thumbnails?.Clone();
        }
    }
}