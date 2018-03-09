using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public interface IPagedResponse<T> : IResponse
        where T : IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        string NextPageToken { get; }

        /// <summary>
        /// 
        /// </summary>
        string PrevPageToken { get; }

        /// <summary>
        /// 
        /// </summary>
        PageInfo PageInfo { get; }

        /// <summary>
        /// 
        /// </summary>
        IList<T> Items { get; }
    }
}