using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Interfaces
{
    public interface IPagedResponse<T> : IResponse
        where T : ISnippetResponse
    {
        string NextPageToken { get; }
        string PrevPageToken { get; }
        PageInfo PageInfo { get; }
        IList<T> Items { get; }
    }
}
