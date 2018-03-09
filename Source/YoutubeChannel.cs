using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Channels;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeChannel : YoutubeItem<Channel, ChannelApiRequestSettings>, IYoutubeItem
    {
        private Channel _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _description;
        private string _customUrl;
        private DateTime _publishedAt;
        private IReadOnlyDictionary<ThumbnailSize, Thumbnail> _thumbnails;

        public Channel Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public string Title => S(ref _title);
        public string Description => S(ref _description);
        public string CustomUrl => S(ref _customUrl);
        public DateTime PublishedAt => S(ref _publishedAt);
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails => S(ref _thumbnails);

        public YoutubeChannel(IApiRequest<Channel, ChannelApiRequestSettings> request) : base(request) { }

        public YoutubeChannel(Channel response) : base(response) { }

        protected override void SetProperties(Channel response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _title = response.Snippet?.Title;
            _description = response.Snippet?.Description;
            _customUrl = response.Snippet?.CustomUrl;
            _publishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            _thumbnails = response.Snippet?.Thumbnails?.Clone();
        }
    }
}