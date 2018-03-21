using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.Videos;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeVideo : YoutubeItem<Video, VideoApiRequestSettings>, IYoutubeItem
    {
        private Video _item;
        public Video Item => Set(ref _item);

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

        private int _categoryId;
        public int CategoryId => Set(ref _categoryId);

        private long _commentCount;
        public long CommentCount => Set(ref _commentCount);

        private long _dislikeCount;
        public long DislikeCount => Set(ref _dislikeCount);

        private long _likeCount;
        public long LikeCount => Set(ref _likeCount);

        private long _viewCount;
        public long ViewCount => Set(ref _viewCount);

        private TimeSpan _duration;
        public TimeSpan Duration => Set(ref _duration);

        private Definition _definition;
        public Definition Definition => Set(ref _definition);

        private Dimension _dimension;
        public Dimension Dimension => Set(ref _dimension);

        public YoutubeVideo(IApiRequest<Video, VideoApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeVideo(Video response) : base(response)
        {
        }

        protected override void SetProperties(Video response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet != null)
            {
                _publishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
                _channelId = response.Snippet.ChannelId;
                _title = response.Snippet.Title;
                _description = response.Snippet.Description;
                _channelTitle = response.Snippet.ChannelTitle;
                int.TryParse(response.Snippet.CategoryId, out _categoryId);
                _thumbnails = response.Snippet.Thumbnails?.Clone();
            }

            if (response.Statistics != null)
            {
                _commentCount = response.Statistics.CommentCount.GetValueOrDefault();
                _dislikeCount = response.Statistics.DislikeCount.GetValueOrDefault();
                _likeCount = response.Statistics.LikeCount.GetValueOrDefault();
                _viewCount = response.Statistics.ViewCount.GetValueOrDefault();
            }

            if (response.ContentDetails != null)
            {
                _duration = response.ContentDetails.Duration.GetValueOrDefault();
                _definition = response.ContentDetails.Definition.GetValueOrDefault();
                _dimension = response.ContentDetails.Dimension.GetValueOrDefault();
            }
        }
    }
}