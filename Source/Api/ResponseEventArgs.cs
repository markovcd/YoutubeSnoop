using System;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api
{
    public class ResponseEventArgs<TResponse> : EventArgs
        where TResponse : IResponse
    {
        public string PageToken { get; }
        public IPagedResponse<TResponse> Response { get; }

        public ResponseEventArgs(string pageToken, IPagedResponse<TResponse> response)
        {
            PageToken = pageToken;
            Response = response;
        }
    }
}
