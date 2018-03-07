namespace YoutubeSnoop.Api.Entities.Comments
{
    class Comment : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
