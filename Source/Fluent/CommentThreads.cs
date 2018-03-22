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
            var request = GetDefaultRequest<CommentThread, CommentThreadApiRequestSettings>(settings, partTypes);
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = GetDefaultRequest<CommentThread, CommentThreadApiRequestSettings>(settings, partTypes);
            return new YoutubeCommentThread(request);
        }

        public static YoutubeCommentThreads CommentThreads(CommentThreadApiRequestSettings settings = null)
        {
            return CommentThreads(settings ?? new CommentThreadApiRequestSettings(), PartType.Snippet, PartType.Replies);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadApiRequestSettings settings = null)
        {
            return CommentThread(settings ?? new CommentThreadApiRequestSettings(), PartType.Snippet, PartType.Replies);
        }

        public static YoutubeCommentThreads CommentThreads(params string[] ids)
        {
            return CommentThreads(new CommentThreadApiRequestSettings { Id = ids.Aggregate() });
        }

        public static YoutubeCommentThread CommentThread(string id)
        {
            return CommentThread(new CommentThreadApiRequestSettings { Id = id });
        }

        public static YoutubeCommentThreads RequestId(this YoutubeCommentThreads commentThreads, params string[] ids)
        {
            var request = commentThreads.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads RequestPart(this YoutubeCommentThreads commentThreads, PartType partType)
        {
            var request = commentThreads.Request.RequestPart(partType);
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads RequestReplies(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.RequestPart(PartType.Replies);
        }

        public static YoutubeCommentThreads RequestSnippet(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.RequestPart(PartType.Snippet);
        }

        public static YoutubeCommentThreads RequestAllParts(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.RequestReplies().RequestSnippet();
        }

        public static YoutubeCommentThread RequestPart(this YoutubeCommentThread commentThread, PartType partType)
        {
            var request = commentThread.Request.RequestPart(partType);
            return new YoutubeCommentThread(request);
        }

        public static YoutubeCommentThread RequestReplies(this YoutubeCommentThread commentThread)
        {
            return commentThread.RequestPart(PartType.Replies);
        }

        public static YoutubeCommentThread RequestSnippet(this YoutubeCommentThread commentThread)
        {
            return commentThread.RequestPart(PartType.Snippet);
        }

        public static YoutubeCommentThread RequestAllParts(this YoutubeCommentThread commentThread)
        {
            return commentThread.RequestReplies().RequestSnippet();
        }

        public static YoutubeCommentThreads ForChannelId(this YoutubeCommentThreads commentThreads, string id)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads ForVideoId(this YoutubeCommentThreads commentThreads, string id)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.VideoId = id;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads ForChannelIdAll(this YoutubeCommentThreads commentThreads, string id)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.AllThreadsRelatedToChannelId = id;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads OrderBy(this YoutubeCommentThreads commentThreads, CommentOrder order)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.Order = order;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThreads OrderByTime(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.OrderBy(CommentOrder.Time);
        }

        public static YoutubeCommentThreads OrderByRelevance(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.OrderBy(CommentOrder.Relevance);
        }

        public static YoutubeCommentThreads SearchTerms(this YoutubeCommentThreads commentThreads, string s)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.SearchTerms = s;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThread SearchTerms(this YoutubeCommentThread commentThread, string s)
        {
            var request = commentThread.Request.Clone();
            request.Settings.SearchTerms = s;
            return new YoutubeCommentThread(request);
        }

        public static YoutubeCommentThread TextFormat(this YoutubeCommentThread commentThread, TextFormat format)
        {
            var request = commentThread.Request.Clone();
            request.Settings.TextFormat = format;
            return new YoutubeCommentThread(request);
        }

        public static YoutubeCommentThreads TextFormat(this YoutubeCommentThreads commentThreads, TextFormat format)
        {
            var request = commentThreads.Request.Clone();
            request.Settings.TextFormat = format;
            return new YoutubeCommentThreads(request);
        }

        public static YoutubeCommentThread FormatHtml(this YoutubeCommentThread commentThread)
        {
            return commentThread.TextFormat(Enums.TextFormat.Html);
        }

        public static YoutubeCommentThread FormatPlainText(this YoutubeCommentThread commentThread)
        {
            return commentThread.TextFormat(Enums.TextFormat.PlainText);
        }

        public static YoutubeCommentThreads FormatHtml(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.TextFormat(Enums.TextFormat.Html);
        }

        public static YoutubeCommentThreads FormatPlainText(this YoutubeCommentThreads commentThreads)
        {
            return commentThreads.TextFormat(Enums.TextFormat.PlainText);
        }

        public static YoutubeVideo Video(this YoutubeCommentThread commentThread)
        {
            if (commentThread.VideoId == null) commentThread = commentThread.RequestSnippet();
            if (commentThread.VideoId == null) return null;
            return Video(commentThread.VideoId);
        }

        public static YoutubeChannel Channel(this YoutubeCommentThread commentThread)
        {
            if (commentThread.ChannelId == null) commentThread = commentThread.RequestSnippet();
            if (commentThread.ChannelId == null) return null;
            return Channel(commentThread.ChannelId);
        }
    }
}