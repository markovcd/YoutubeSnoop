namespace YoutubeSnoop.Api.Entities.CommentThreads
{
    class CommentThread : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public Replies Replies { get; set; }
    }
}
