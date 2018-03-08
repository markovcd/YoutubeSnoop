namespace YoutubeSnoop.Api.Entities.Captions
{
    public class Caption : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
