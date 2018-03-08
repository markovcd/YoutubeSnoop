using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Api.Entities.Subscriptions;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api;

namespace YoutubeSnoop
{
    public class YoutubeSubscription : YoutubeItem<Subscription, SubscriptionApiRequestSettings>, IYoutubeItem
    {
        private string _id;
        private Subscription _item;
        private ResourceKind _kind;
        private string _channelId;
        private DateTime _publishedAt;
        private string _title;
        private string _description;
        private string _channelTitle;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;

        public Subscription Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public DateTime PublishedAt => S(ref _publishedAt);
        public string ChannelId => S(ref _channelId);
        public string Title => S(ref _title);
        public string Description => S(ref _description);
        public string ChannelTitle => S(ref _channelTitle);
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => S(ref _thumbnails);

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