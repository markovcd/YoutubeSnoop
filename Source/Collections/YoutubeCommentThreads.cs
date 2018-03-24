using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.CommentThreads;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeCommentThreads : YoutubeCollection<YoutubeCommentThread, CommentThread, CommentThreadSettings>
    {
        public YoutubeCommentThreads(CommentThreadSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}