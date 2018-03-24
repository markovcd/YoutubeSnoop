using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.Comments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeComments : YoutubeCollection<YoutubeComment, Comment, CommentSettings>
    {
        public YoutubeComments(CommentSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}