using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeComment : YoutubeItem<Comment, CommentSettings>, IYoutubeItem
    {
        private Comment _rawData;
        public Comment RawData => Set(ref _rawData);

        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private DateTime _publishedAt;
        public DateTime PublishedAt => Set(ref _publishedAt);

        private string _textDisplay;
        public string TextDisplay => Set(ref _textDisplay);

        private DateTime _updatedAt;
        public DateTime UpdatedAt => Set(ref _updatedAt);

        private string _videoId;
        public string VideoId => Set(ref _videoId);

        private string _authorChannelId;
        public string AuthorChannelId => Set(ref _authorChannelId);

        private string _authorChannelUrl;
        public string AuthorChannelUrl => Set(ref _authorChannelUrl);

        private string _authorDisplayName;
        public string AuthorDisplayName => Set(ref _authorDisplayName);

        private string _authorProfileImageUrl;
        public string AuthorProfileImageUrl => Set(ref _authorProfileImageUrl);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        private int _likeCount;
        public int LikeCount => Set(ref _likeCount);

        private string _parentId;
        public string ParentId => Set(ref _parentId);

        public YoutubeComment(Comment response) : base(response)
        {
        }

        public YoutubeComment(CommentSettings settings, IEnumerable<PartType> partTypes = null) : base(settings, partTypes)
        {
        }

        protected override void SetProperties(Comment response)
        {
            if (response == null) return;

            _rawData = response;
            _id = response.Id;
            _kind = response.Kind;

            if (response.Snippet == null) return;

            _publishedAt = response.Snippet.PublishedAt.GetValueOrDefault();
            _authorChannelId = response.Snippet.AuthorChannelId?.Value;
            _authorChannelUrl = response.Snippet.AuthorChannelUrl;
            _authorDisplayName = response.Snippet.AuthorDisplayName;
            _authorProfileImageUrl = response.Snippet.AuthorProfileImageUrl;
            _channelId = response.Snippet.ChannelId;
            _likeCount = response.Snippet.LikeCount.GetValueOrDefault();
            _parentId = response.Snippet.ParentId;
            _textDisplay = response.Snippet.TextDisplay;
            _updatedAt = response.Snippet.UpdatedAt.GetValueOrDefault();
            _videoId = response.Snippet.VideoId;
        }

        public override string ToString()
        {
            return _textDisplay ?? base.ToString();
        }
    }
}