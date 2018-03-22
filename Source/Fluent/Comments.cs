using System.Linq;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeComments Comments(CommentApiRequestSettings settings = null)
        {
            var request = GetDefaultRequest<Comment, CommentApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeComments(request);
        }

        public static YoutubeComment Comment(CommentApiRequestSettings settings = null)
        {
            var request = GetDefaultRequest<Comment, CommentApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeComment(request);
        }

        public static YoutubeComments Comments(params string[] ids)
        {
            return Comments(new CommentApiRequestSettings { Id = ids.Aggregate() });
        }

        public static YoutubeComment Comment(string id)
        {
            return Comment(new CommentApiRequestSettings { Id = id });
        }

        public static YoutubeComments ForParentId(this YoutubeComments comments, string id)
        {
            var request = comments.Request.Clone();
            request.Settings.ParentId = id;
            return new YoutubeComments(request);
        }

        public static YoutubeComments TextFormat(this YoutubeComments comments, TextFormat f)
        {
            var request = comments.Request.Clone();
            request.Settings.TextFormat = f;
            return new YoutubeComments(request);
        }

        public static YoutubeComment TextFormat(this YoutubeComment comment, TextFormat f)
        {
            var request = comment.Request.Clone();
            request.Settings.TextFormat = f;
            return new YoutubeComment(request);
        }

        public static YoutubeComment FormatHtml(this YoutubeComment comment)
        {
            return comment.TextFormat(Enums.TextFormat.Html);
        }

        public static YoutubeComment FormatPlainText(this YoutubeComment comment)
        {
            return comment.TextFormat(Enums.TextFormat.PlainText);
        }

        public static YoutubeComments FormatHtml(this YoutubeComments comments)
        {
            return comments.TextFormat(Enums.TextFormat.Html);
        }

        public static YoutubeComments FormatPlainText(this YoutubeComments comments)
        {
            return comments.TextFormat(Enums.TextFormat.PlainText);
        }

        public static YoutubeComments RequestId(this YoutubeComments comments, params string[] ids)
        {
            var request = comments.Request.Clone();
            if (request.Settings.Id == null) request.Settings.Id = "";

            request.Settings.Id = request.Settings.Id.AddItems(ids);

            return new YoutubeComments(request);
        }

        public static YoutubeComments Replies(this YoutubeComment comment)
        {
            return Comments().ForParentId(comment.Id);
        }

        public static YoutubeComment Parent(this YoutubeComment comment)
        {
            if (comment.ParentId == null) return null;
            return Comment(comment.ParentId);
        }

        public static YoutubeVideo Video(this YoutubeComment comment)
        {
            if (comment.VideoId == null) return null;
            return Video(comment.VideoId);
        }

        public static YoutubeChannel Channel(this YoutubeComment comment)
        {
            if (comment.ChannelId == null) return null;
            return Channel(comment.ChannelId);
        }

        public static YoutubeChannel AuthorChannel(this YoutubeComment comment)
        {
            if (comment.AuthorChannelId == null) return null;
            return Channel(comment.AuthorChannelId);
        }
    }
}