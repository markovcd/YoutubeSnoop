using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    public interface IApiRequest<TItem, TSettings> : IEnumerable<IPagedResponse<TItem>>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        IEnumerable<TItem> Items { get; }
        TItem FirstItem { get; }
        TSettings Settings { get; }
        IEnumerable<PartType> PartTypes { get; }
    }
}
