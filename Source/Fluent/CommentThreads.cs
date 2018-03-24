using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCommentThreads CommentThreads(CommentThreadSettings settings, params PartType[] partTypes)
        {
            return new YoutubeCommentThreads(settings, partTypes, ResultsPerPage);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadSettings settings, params PartType[] partTypes)
        {
            return new YoutubeCommentThread(settings, partTypes);
        }

        public static YoutubeCommentThreads CommentThreads(CommentThreadSettings settings = null)
        {
            return CommentThreads(settings, PartType.Snippet, PartType.Replies);
        }

        public static YoutubeCommentThread CommentThread(CommentThreadSettings settings = null)
        {
            return CommentThread(settings, PartType.Snippet, PartType.Replies);
        }

        public static YoutubeCommentThreads CommentThreads(params string[] ids)
        {
            return CommentThreads(new CommentThreadSettings { Id = ids.Aggregate() });
        }

        public static YoutubeCommentThread CommentThread(string id)
        {
            return CommentThread(new CommentThreadSettings { Id = id });
        }

        public static YoutubeCommentThreads RequestId(this YoutubeCommentThreads commentThreads, params string[] ids)
        {
            var settings = commentThreads.Settings.Clone();
            settings.Id = settings.Id.AddItems(ids);
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
        }

        public static YoutubeCommentThreads RequestPart(this YoutubeCommentThreads commentThreads, PartType partType)
        {
            return CommentThreads(commentThreads.Settings.Clone(), commentThreads.PartTypes.Append(partType).ToArray());
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
            return CommentThread(commentThread.Settings.Clone(), commentThread.PartTypes.Append(partType).ToArray());
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
            var settings = commentThreads.Settings.Clone();
            settings.ChannelId = id;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
        }

        public static YoutubeCommentThreads ForVideoId(this YoutubeCommentThreads commentThreads, string id)
        {
            var settings = commentThreads.Settings.Clone();
            settings.VideoId = id;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
        }

        public static YoutubeCommentThreads ForChannelIdAll(this YoutubeCommentThreads commentThreads, string id)
        {
            var settings = commentThreads.Settings.Clone();
            settings.AllThreadsRelatedToChannelId = id;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
        }

        public static YoutubeCommentThreads OrderBy(this YoutubeCommentThreads commentThreads, CommentOrder order)
        {
            var settings = commentThreads.Settings.Clone();
            settings.Order = order;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
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
            var settings = commentThreads.Settings.Clone();
            settings.SearchTerms = s;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
        }

        public static YoutubeCommentThread SearchTerms(this YoutubeCommentThread commentThread, string s)
        {
            var settings = commentThread.Settings.Clone();
            settings.SearchTerms = s;
            return CommentThread(settings, commentThread.PartTypes.ToArray());
        }

        public static YoutubeCommentThread TextFormat(this YoutubeCommentThread commentThread, TextFormat format)
        {
            var settings = commentThread.Settings.Clone();
            settings.TextFormat = format;
            return CommentThread(settings, commentThread.PartTypes.ToArray());
        }

        public static YoutubeCommentThreads TextFormat(this YoutubeCommentThreads commentThreads, TextFormat format)
        {
            var settings = commentThreads.Settings.Clone();
            settings.TextFormat = format;
            return CommentThreads(settings, commentThreads.PartTypes.ToArray());
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