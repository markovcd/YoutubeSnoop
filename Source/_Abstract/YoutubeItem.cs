using System;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public abstract class YoutubeItem<TResponse, TSettings>
        where TResponse : class, IResponse
        where TSettings : class, ISettings
    {
        private bool _propertiesSet;

        protected IRequest<TResponse, TSettings> Request { get; }

        public TSettings Settings { get; }
        public IReadOnlyList<PartType> PartTypes { get; }

        protected YoutubeItem(IRequest<TResponse, TSettings> request)
        {
            Request = request;
            PartTypes = request.PartTypes.ToList().AsReadOnly();
            Settings = request.Settings.Clone();
        }

        protected YoutubeItem(TSettings settings = null, IEnumerable<PartType> partTypes = null) 
            : this(Api.Request.Create<TResponse, TSettings>(settings, partTypes, 1))
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