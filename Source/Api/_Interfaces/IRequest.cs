using System;
using System.Collections.Generic;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public interface IRequest<TResponse, TSettings> : IEnumerable<IPagedResponse<TResponse>>
        where TResponse : IResponse
        where TSettings : ISettings
    {
        IEnumerable<TResponse> Items { get; }
        TResponse FirstItem { get; }
        TSettings Settings { get; }
        IEnumerable<PartType> PartTypes { get; }
        event EventHandler<ResponseEventArgs<TResponse>> Deserialized;
    }
}