using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Activities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeActivity : YoutubeItem<Activity, ActivityApiRequestSettings>, IYoutubeItem
    {
        private Activity _item;
        private string _id;
        private ResourceKind _kind;
        private string _title;
        private string _description;
        private DateTime _publishedAt;
        private IReadOnlyDictionary<string, Thumbnail> _thumbnails;
        private string _channelId;
        private string _channelTitle;
        private string _groupId;
        private ActivityType _type;

        public Activity Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public string Title => S(ref _title);
        public string Description => S(ref _description);
        public DateTime PublishedAt => S(ref _publishedAt);
        public IReadOnlyDictionary<string, Thumbnail> Thumbnails => S(ref _thumbnails);
        public string ChannelId => S(ref _channelId);
        public string ChannelTitle => S(ref _channelTitle);
        public string GroupId => S(ref _groupId);
        public ActivityType Type => S(ref _type);

        public YoutubeActivity(IApiRequest<Activity, ActivityApiRequestSettings> request) : base(request) { }

        public YoutubeActivity(Activity response) : base(response) { }

        protected override void SetProperties(Activity response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _title = response.Snippet?.Title;
            _description = response.Snippet?.Description;
            _publishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            _thumbnails = response.Snippet?.Thumbnails?.Clone();
            _channelId = response.Snippet?.ChannelId;
            _channelTitle = response.Snippet?.ChannelTitle;
            _groupId = response.Snippet?.GroupId;
            _type = (response.Snippet?.Type).GetValueOrDefault();
        }
    }
}