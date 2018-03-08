namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    public class CommentThread : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public Replies Replies { get; set; }
    }
}
