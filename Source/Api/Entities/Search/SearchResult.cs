namespace YoutubeSnoop.Api.Entities.Search
{
    public class SearchResult : Response
    {
        /// <summary>
        /// The id object contains information that can be used to uniquely identify the resource that matches the search request.
        /// </summary>
        public Resource Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about a search result, such as its title or description. For example, if the search result is a video, then the title will be the video's title and the description will be the video's description.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}