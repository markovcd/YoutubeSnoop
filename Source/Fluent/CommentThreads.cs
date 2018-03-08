using System.Linq;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCommentThreads CommentThreads(CommentThreadApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<CommentThread, CommentThreadApiRequestSettings>(settings, partTypes);
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<CommentThread, CommentThreadApiRequestSettings>(settings, partTypes);
            return new YoutubeCommentThread(request);
        }

        public static YoutubeCommentThreads CommentThreads(CommentThreadApiRequestSettings settings = null)
        {
            return CommentThreads(settings ?? new CommentThreadApiRequestSettings(), PartType.Snippet, PartType.ContentDetails);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadApiRequestSettings settings = null)
        {
            return CommentThread(settings ?? new CommentThreadApiRequestSettings(), PartType.Snippet, PartType.ContentDetails);
        }
    }
}
