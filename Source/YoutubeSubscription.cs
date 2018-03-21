using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api;

namespace YoutubeSnoop
{
    public sealed class YoutubeSubscription : YoutubeItem<Subscription, SubscriptionApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private Subscription _item;
        private ResourceKind _kind;
        private string _channelId;
        private DateTime _publishedAt;
        private string _title;
        private string _description;
        private string _channelTitle;
        private IReadOnlyDictionary<ThumbnailSize, Thumbnail> _thumbnails;

        public Subscription Item => Set(ref _item);
        public string Id => Set(ref _id);
        public ResourceKind Kind => Set(ref _kind);
        public DateTime PublishedAt => Set(ref _publishedAt);
        public string ChannelId => Set(ref _channelId);
        public string Title => Set(ref _title);
        public string Description => Set(ref _description);
        public string ChannelTitle => Set(ref _channelTitle);
        public IReadOnlyDictionary<ThumbnailSize, Thumbnail> Thumbnails => Set(ref _thumbnails);

        public YoutubeSubscription(IApiRequest<Subscription, SubscriptionApiRequestSettings> request) : base(request) { }

        public YoutubeSubscription(Subscription response) : base(response) { }

        protected override void SetProperties(Subscription response)
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
            // todo
            _thumbnails = response.Snippet?.Thumbnails?.Clone();
        }
    }
}