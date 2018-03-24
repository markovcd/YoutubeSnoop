using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        protected IApiRequest<TResponse, TSettings> Request { get; }

        public TSettings Settings { get; }
        public IReadOnlyList<PartType> PartTypes { get; }

        private int? _resultsPerPage;
        public int? ResultsPerPage => _resultsPerPage; // TODO : will be set when first page is downloaded

        private int? _totalResults;
        public int? TotalResults => _totalResults; // TODO : will be set when first page is downloaded

        protected YoutubeCollection(IApiRequest<TResponse, TSettings> request)
        {
            Request = request;
            PartTypes = request.PartTypes.ToList().AsReadOnly();
            Settings = request.Settings.Clone();
        }

        protected YoutubeCollection(TSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20) 
            : this(ApiRequest.Create<TResponse, TSettings>(settings, partTypes, resultsPerPage))
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