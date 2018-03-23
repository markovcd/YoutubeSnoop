using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeCommentThreads : YoutubeCollection<YoutubeCommentThread, CommentThread, CommentThreadApiRequestSettings>
    {
        public YoutubeCommentThreads(IApiRequest<CommentThread, CommentThreadApiRequestSettings> request) : base(request)
        {
        }
    }
}