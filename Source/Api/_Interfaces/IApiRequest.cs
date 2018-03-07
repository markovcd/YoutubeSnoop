using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
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
