namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class CommentThread : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the comment thread.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the comment thread. It also contains the thread's top-level comment, which is a comment resource.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The replies object is a container that contains a list of replies to the comment, if any exist. The replies.comments property represents the list of comments itself.
        /// </summary>
        public Replies Replies { get; set; }
    }
}