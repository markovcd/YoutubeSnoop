namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class CommentThread : Response
    {

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Replies Replies { get; set; }
    }
}
