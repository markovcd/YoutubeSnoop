﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public abstract class YoutubeCollection<TItem, TResponse, TSettings> : IYoutubeCollection<TItem>
        where TItem : IYoutubeItem
        where TResponse : class, IResponse
        where TSettings : class, ISettings
    {
        protected IRequest<TResponse, TSettings> Request { get; }

        public TSettings Settings { get; }
        public IReadOnlyList<PartType> PartTypes { get; }

        private int? _resultsPerPage;
        public int? ResultsPerPage => _resultsPerPage;

        private int? _totalResults;
        public int? TotalResults => _totalResults;

        protected YoutubeCollection(IRequest<TResponse, TSettings> request)
        {
            Request = request;
            PartTypes = request.PartTypes.ToList().AsReadOnly();
            Settings = request.Settings.Clone();
            Request.Deserialized += Request_Deserialized;
        }

        private void Request_Deserialized(object sender, ResponseEventArgs<TResponse> e)
        {
            _resultsPerPage = e.Response.PageInfo.ResultsPerPage;
            _totalResults = e.Response.PageInfo.TotalResults;
            Request.Deserialized -= Request_Deserialized;
        }

        protected YoutubeCollection(TSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : this(Api.Request.Create<TResponse, TSettings>(settings, partTypes, resultsPerPage))
        {
            _resultsPerPage = resultsPerPage;
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