using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public interface IPagedResponse<T> : IResponse
        where T : IResponse
    {
        string NextPageToken { get; }
        string PrevPageToken { get; }
        PageInfo PageInfo { get; }
        IList<T> Items { get; }
    }
}