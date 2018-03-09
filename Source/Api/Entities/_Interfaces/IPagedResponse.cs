using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public interface IPagedResponse<T> : IResponse
        where T : IResponse
    {
        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the next page in the result set.
        /// </summary>
        string NextPageToken { get; }

        /// <summary>
        /// The token that can be used as the value of the pageToken parameter to retrieve the previous page in the result set.
        /// </summary>
        string PrevPageToken { get; }

        /// <summary>
        /// The pageInfo object encapsulates paging information for the result set.
        /// </summary>
        PageInfo PageInfo { get; }

        /// <summary>
        /// List of items contained in the API response.
        /// </summary>
        IList<T> Items { get; }
    }
}