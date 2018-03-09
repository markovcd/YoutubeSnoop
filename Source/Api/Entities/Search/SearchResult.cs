namespace YoutubeSnoop.Api.Entities.Search
{
    public class SearchResult : Response
    {
        /// <summary>
        /// 
        /// </summary>
        public IResource Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}