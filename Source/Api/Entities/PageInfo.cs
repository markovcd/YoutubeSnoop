namespace YoutubeSnoop.Api.Entities
{
    public class PageInfo
    {
        /// <summary>
        /// The total number of results in the result set.
        /// </summary>
        public int TotalResults { get; set; }

        /// <summary>
        /// The number of results included in the API response.
        /// </summary>
        public int ResultsPerPage { get; set; }
    }
}