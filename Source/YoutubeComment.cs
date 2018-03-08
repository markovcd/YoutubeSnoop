using System;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeComment : YoutubeItem<Comment, CommentApiRequestSettings>, IYoutubeItem
    {
        private Comment _item;
        private string _id;
        private ResourceKind _kind;
        private DateTime _publishedAt;
        private string _textDisplay;
        private DateTime _updatedAt;
        private string _videoId;
        private string _authorChannelId;
        private string _authorChannelUrl;
        private string _authorDisplayName;
        private string _authorProfileImageUrl;
        private string _channelId;
        private int _likeCount;
        private string _parentId;

        public Comment Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public DateTime PublishedAt => S(ref _publishedAt);
        public string TextDisplay => S(ref _textDisplay);
        public DateTime UpdatedAt => S(ref _updatedAt);
        public string VideoId => S(ref _videoId);
        public string AuthorChannelId => S(ref _authorChannelId);
        public string AuthorChannelUrl => S(ref _authorChannelUrl);
        public string AuthorDisplayName => S(ref _authorDisplayName);
        public string AuthorProfileImageUrl => S(ref _authorProfileImageUrl);
        public string ChannelId => S(ref _channelId);
        public int LikeCount => S(ref _likeCount);
        public string ParentId => S(ref _parentId);

        public YoutubeComment(IApiRequest<Comment, CommentApiRequestSettings> request) : base(request) { }

        public YoutubeComment(Comment response) : base(response) { }

        protected override void SetProperties(Comment response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _publishedAt = (response.Snippet?.PublishedAt).GetValueOrDefault();
            _authorChannelId = response.Snippet?.AuthorChannelId?.Value;
            _authorChannelUrl = response.Snippet?.AuthorChannelUrl;
            _authorDisplayName = response.Snippet?.AuthorDisplayName;
            _authorProfileImageUrl = response.Snippet?.AuthorProfileImageUrl;
            _channelId = response.Snippet?.ChannelId;
            _likeCount = (response.Snippet?.LikeCount).GetValueOrDefault();
            _parentId = response.Snippet?.ParentId;          
            _textDisplay = response.Snippet?.TextDisplay;
            _updatedAt = (response.Snippet?.UpdatedAt).GetValueOrDefault();
            _videoId = response.Snippet?.VideoId;            
        }
    }
}