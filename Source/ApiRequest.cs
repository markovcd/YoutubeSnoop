using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
{
    public interface IApiRequest<TItem, TSettings> : IEnumerable<IPagedResponse<TItem>>
        where TItem : IResponse
        where TSettings : IApiRequestSettings
    {
        IEnumerable<TItem> Items { get; }
        TItem FirstItem { get; }
        TSettings Settings { get; }

        IApiRequest<TItem, TSettings> DeepClone();

        event EventHandler FirstItemDownloaded;
    }

    public class ApiRequest<TItem, TSettings> : IApiRequest<TItem, TSettings>
        where TItem : class, IResponse
        where TSettings : IApiRequestSettings
    {
        private readonly IJsonDownloader _jsonDownloader;
        private readonly IResponseDeserializer<TItem> _responseDeserializer;
        private readonly IApiUrlFormatter<TSettings> _apiUrlFormatter;

        private TItem _firstItem;
        public TItem FirstItem
        {
            get
            {
                if (_firstItem == null)
                {
                    _firstItem = Items.FirstOrDefault();
                    OnFirstItemDownloaded(new EventArgs());
                }
                return _firstItem;
            }
        }

        public IEnumerable<TItem> Items { get; }
        public TSettings Settings { get; }
        public int ResultsPerPage { get; }

        public IEnumerable<PartType> PartTypes { get; }

        public event EventHandler FirstItemDownloaded;

        public ApiRequest(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter<TSettings> apiUrlFormatter)
        {
            _jsonDownloader = jsonDownloader;
            _responseDeserializer = responseDeserializer;
            _apiUrlFormatter = apiUrlFormatter;

            ResultsPerPage = resultsPerPage;
            Settings = settings;
            PartTypes = partTypes ?? new[] { PartType.Snippet };

            Items = this.SelectMany(i => i.Items);
        }

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
        public IApiRequest<TItem, TSettings> DeepClone()
        {
            return new ApiRequest<TItem, TSettings>((TSettings)Settings.DeepClone(), PartTypes.ToList(), ResultsPerPage, _jsonDownloader, _responseDeserializer, _apiUrlFormatter);
        }

        protected void OnFirstItemDownloaded(EventArgs a)
        {
            FirstItemDownloaded?.Invoke(this, a);
        }
    }
}