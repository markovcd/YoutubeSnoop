using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public abstract class YoutubeCollection<TItem, TResponse, TSettings> : IYoutubeCollection<TItem>
        where TItem : IYoutubeItem
        where TResponse : IResponse
        where TSettings : IApiRequestSettings
    {
        public IApiRequest<TResponse, TSettings> Request { get; }

        protected YoutubeCollection(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            return Request.Items.Select(CreateItem).GetEnumerator();
        }

        protected abstract TItem CreateItem(TResponse response);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}