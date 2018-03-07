namespace YoutubeSnoop.Api.Entities.Captions
{
    class Caption : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
