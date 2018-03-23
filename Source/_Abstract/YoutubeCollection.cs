using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public abstract class YoutubeCollection<TItem, TResponse, TSettings> : IYoutubeCollection<TItem>
        where TItem : IYoutubeItem
        where TResponse : class, IResponse
        where TSettings : class, IApiRequestSettings
    {
        public IApiRequest<TResponse, TSettings> Request { get; }

        protected YoutubeCollection(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
        }

        protected YoutubeCollection(TSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20) : this(ApiRequest.Create<TResponse, TSettings>(settings ?? Activator.CreateInstance<TSettings>(), partTypes, resultsPerPage))
        {
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            return Request.Items.Select(CreateItem).GetEnumerator();
        }

        protected virtual TItem CreateItem(TResponse response)
        {
            return (TItem)Activator.CreateInstance(typeof(TItem), response);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}