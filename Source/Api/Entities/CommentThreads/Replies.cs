using System.Collections.Generic;
using YoutubeSnoop.Api.Entities.Comments;

namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class Replies
    {
        public IList<Comment> Comments { get; set; }
    }
}