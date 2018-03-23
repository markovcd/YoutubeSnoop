using System;
using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public abstract class YoutubeItem<TResponse, TSettings>
        where TResponse : class, IResponse
        where TSettings : class, IApiRequestSettings
    {
        private bool _propertiesSet;

        public IApiRequest<TResponse, TSettings> Request { get; }

        protected YoutubeItem(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
        }

        protected YoutubeItem(TSettings settings = null, IEnumerable<PartType> partTypes = null) : this(ApiRequest.Create<TResponse, TSettings>(settings ?? Activator.CreateInstance<TSettings>(), partTypes, 1))
        {
        }

        protected YoutubeItem(TResponse response)
        {
#pragma warning disable RECS0021 // Don't tell me how to live my life, fucker
            SetProperties(response);
#pragma warning restore RECS0021

            _propertiesSet = true;
        }

        protected abstract void SetProperties(TResponse response);

        protected T Set<T>(ref T field)
        {
            if (!_propertiesSet) SetProperties(Request.FirstItem);
            _propertiesSet = true;
            return field;
        }
    }
}