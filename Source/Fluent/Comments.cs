using System.Linq;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeComments Comments(CommentApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Comment, CommentApiRequestSettings>(settings, partTypes);
            return new YoutubeComments(request);
        }

        public static YoutubeComment Comment(CommentApiRequestSettings settings, params PartType[] partTypes)
        {
            var request = DefaultRequest<Comment, CommentApiRequestSettings>(settings, partTypes);
            return new YoutubeComment(request);
        }

        public static YoutubeComments Comments(CommentApiRequestSettings settings = null)
        {
            return Comments(settings ?? new CommentApiRequestSettings(), PartType.Snippet);
        }

        public static YoutubeComment Comment(CommentApiRequestSettings settings = null)
        {
            return Comment(settings ?? new CommentApiRequestSettings(), PartType.Snippet);
        }
    }
}
