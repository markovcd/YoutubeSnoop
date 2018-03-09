using System.Collections.Generic;
using YoutubeSnoop.Api.Entities.Comments;

namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class Replies
    {

        /// <summary>
        /// A list of one or more replies to the top-level comment. Each item in the list is a comment resource.
        /// </summary>
        /// <remarks>
        /// The list contains a limited number of replies, and unless the number of items in the list equals the value of the snippet.totalReplyCount property, the list of replies is only a subset of the total number of replies available for the top-level comment. To retrieve all of the replies for the top-level comment, you need to call the comments.list method and use the parentId request parameter to identify the comment for which you want to retrieve replies.
        /// </remarks>
        public IList<Comment> Comments { get; set; }
    }
}