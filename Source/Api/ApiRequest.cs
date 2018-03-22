using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Core functionality class of YoutubeSnoop. 
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <typeparam name="TSettings"></typeparam>
    public class ApiRequest<TItem, TSettings> : IApiRequest<TItem, TSettings>
        where TItem : class, IResponse
        where TSettings : IApiRequestSettings
    {
        private readonly IJsonDownloader _jsonDownloader;
        private readonly IPagedResponseDeserializer<TItem> _responseDeserializer;
        private readonly IApiUrlFormatter _apiUrlFormatter;

        private TItem _firstItem;
        public TItem FirstItem => _firstItem ?? (_firstItem = Items.FirstOrDefault());

        public IEnumerable<TItem> Items { get; }
        public TSettings Settings { get; }
        public int ResultsPerPage { get; }

        public IEnumerable<PartType> PartTypes { get; }

        public ApiRequest(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter apiUrlFormatter)
        {
            _jsonDownloader = jsonDownloader;
            _responseDeserializer = responseDeserializer;
            _apiUrlFormatter = apiUrlFormatter;

            ResultsPerPage = resultsPerPage;
            Settings = settings;
            PartTypes = partTypes == null || !partTypes.Any() ? new[] { PartType.Snippet } : partTypes;

            Items = this.SelectMany(i => i.Items);
        }

        public IPagedResponse<TItem> Deserialize(string pageToken = null)
        {
            return Deserialize(_apiUrlFormatter, _jsonDownloader, _responseDeserializer, Settings, PartTypes, ResultsPerPage, pageToken);
        }

        public static IPagedResponse<TItem> Deserialize(IApiUrlFormatter apiUrlFormatter, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer,
                                                        TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, string pageToken = null)
        {
            var requestUrl = apiUrlFormatter.Format(settings, partTypes, pageToken, resultsPerPage);
            var json = jsonDownloader.Download(requestUrl);
            return responseDeserializer.Deserialize(json);
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