using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeCommentThreads : YoutubeCollection<YoutubeCommentThread, CommentThread, CommentThreadApiRequestSettings>
    {        
        public YoutubeCommentThreads(IApiRequest<CommentThread, CommentThreadApiRequestSettings> request) : base(request) {  }

        protected override YoutubeCommentThread CreateItem(CommentThread response)
        {
            return new YoutubeCommentThread(response);
        }
    }
}