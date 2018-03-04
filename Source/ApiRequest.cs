using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public interface IApiRequest<TItem> : IEnumerable<IPagedResponse<TItem>>
        where TItem : IResponse
    {
        IEnumerable<TItem> Items { get; }
    }

    public class ApiRequest<TItem, TSettings> : IApiRequest<TItem>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        private readonly IJsonDownloader _jsonDownloader;
        private readonly IResponseDeserializer<TItem> _responseDeserializer;
        private readonly IApiUrlFormatter<TSettings> _apiUrlFormatter;

        public IEnumerable<TItem> Items { get; }
        public TSettings Settings { get; }
        public int ResultsPerPage { get; }

        public IEnumerable<PartType> PartTypes { get; }
          
        public ApiRequest(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter<TSettings> apiUrlFormatter)
        {
            _jsonDownloader = jsonDownloader;
            _responseDeserializer = responseDeserializer;
            _apiUrlFormatter = apiUrlFormatter;

            ResultsPerPage = resultsPerPage;
            Settings = settings;
            PartTypes = partTypes ?? new[] { PartType.Snippet };         

            Items = this.SelectMany(r => r.Items);
        }

        public ApiRequest(TSettings settings, PartType partType, int resultsPerPage, IJsonDownloader jsonDownloader, IResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter<TSettings> apiUrlFormatter)
            : this(settings, new[] { partType }, resultsPerPage, jsonDownloader, responseDeserializer, apiUrlFormatter) { }

        public ApiRequest(TSettings settings, int resultsPerPage, IJsonDownloader jsonDownloader, IResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter<TSettings> apiUrlFormatter)
            : this(settings, null, resultsPerPage, jsonDownloader, responseDeserializer, apiUrlFormatter) { }
      
        public IPagedResponse<TItem> Deserialize(string pageToken = null)
        {
            var requestUrl = _apiUrlFormatter.Format(Settings, PartTypes, pageToken, ResultsPerPage);
            var json = _jsonDownloader.Download(requestUrl);
            return _responseDeserializer.Deserialize(json);
        }

        public IEnumerator<IPagedResponse<TItem>> GetEnumerator()
        {
            return new PagedResponseEnumerator<TItem>(Deserialize);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}