using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeCommentThread : YoutubeItem<CommentThread, CommentThreadApiRequestSettings>, IYoutubeItem
    {

        private CommentThread _item;
        public CommentThread Item => Set(ref _item);

        private string _id;
        public string Id => Set(ref _id);

        private ResourceKind _kind;
        public ResourceKind Kind => Set(ref _kind);

        private IReadOnlyList<YoutubeComment> _replies;
        public IReadOnlyList<YoutubeComment> Replies => Set(ref _replies);

        private string _channelId;
        public string ChannelId => Set(ref _channelId);

        private YoutubeComment _topLevelComment;
        public YoutubeComment TopLevelComment => Set(ref _topLevelComment);

        private int _totalReplyCount;
        public int TotalReplyCount => Set(ref _totalReplyCount);

        private string _videoId;
        public string VideoId => Set(ref _videoId);

        public YoutubeCommentThread(IApiRequest<CommentThread, CommentThreadApiRequestSettings> request) : base(request) { }

        public YoutubeCommentThread(CommentThread response) : base(response) { }

        protected override void SetProperties(CommentThread response)
        {
            if (response == null) return;

            _item = response;
            _id = response.Id;
            _kind = response.Kind;
            _replies = response.Replies?.Comments.Select(c => new YoutubeComment(c)).ToList();

            if (response.Snippet == null) return;

            _channelId = response.Snippet.ChannelId;
            _topLevelComment = new YoutubeComment(response.Snippet.TopLevelComment);
            _totalReplyCount = response.Snippet.TotalReplyCount.GetValueOrDefault();
            _videoId = response.Snippet.VideoId;
        }
    }
}