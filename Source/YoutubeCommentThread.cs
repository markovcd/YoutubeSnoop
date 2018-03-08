using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeCommentThread : YoutubeItem<CommentThread, CommentThreadApiRequestSettings>, IYoutubeItem
    {
        private CommentThread _item;
        private string _id;
        private ResourceKind _kind;
        private IList<Comment> _replies;
        private string _channelId;
        private Comment _topLevelComment;
        private int _totalReplyCount;
        private string _videoId;

        public CommentThread Item => S(ref _item);
        public string Id => S(ref _id);
        public ResourceKind Kind => S(ref _kind);
        public IList<Comment> Replies => S(ref _replies);
        public string ChannelId => S(ref _channelId);
        public Comment TopLevelComment => S(ref _topLevelComment);
        public int TotalReplyCount => S(ref _totalReplyCount);
        public string VideoId => S(ref _videoId);

        public YoutubeCommentThread(IApiRequest<CommentThread, CommentThreadApiRequestSettings> request) : base(request) { }

        public YoutubeCommentThread(CommentThread response) : base(response) { }

        protected override void SetProperties(CommentThread response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _replies = response.Replies?.Comments;
            _channelId = response.Snippet?.ChannelId;
            _topLevelComment = response.Snippet?.TopLevelComment;
            _totalReplyCount = (response.Snippet?.TotalReplyCount).GetValueOrDefault();
            _videoId = response.Snippet?.VideoId;
        }
    }
}