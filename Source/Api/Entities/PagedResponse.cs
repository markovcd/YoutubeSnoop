using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class PagedResponse<TItem> : Response, IPagedResponse<TItem>
        where TItem : IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string NextPageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PrevPageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<TItem> Items { get; set; }
    }

    

    
}