namespace YoutubeSnoop.Api.Entities.Search
{
    public class SearchResult : Response
    {
        public IResource Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}