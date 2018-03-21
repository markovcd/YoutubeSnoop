using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class PagedResponse<TItem> : Response, IPagedResponse<TItem>
        where TItem : IResponse
    {
        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result set.
        /// </summary>
        public string NextPageToken { get; set; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the result set.
        /// </summary>
        public string PrevPageToken { get; set; }

        /// <summary>
        /// The pageInfo object encapsulates paging information for the result set.
        /// </summary>
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// List of items contained in the API response.
        /// </summary>
        public IList<TItem> Items { get; set; }
    }
}