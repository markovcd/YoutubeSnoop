using System.Collections.Generic;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class PagedResponse<TItem> : Response, IPagedResponse<TItem>
        where TItem : IResponse
    {
        public string NextPageToken { get; set; }
        public string PrevPageToken { get; set; }
        public PageInfo PageInfo { get; set; }
        public IList<TItem> Items { get; set; }
    }

    

    
}