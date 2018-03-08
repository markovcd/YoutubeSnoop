namespace YoutubeSnoop.Api.Entities.Comments
{
    public class Comment : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
