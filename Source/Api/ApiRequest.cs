using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public static class ApiRequest
    {
        public static ApiRequest<TItem, TSettings> Create<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer, IApiUrlFormatter apiUrlFormatter)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return new ApiRequest<TItem, TSettings>(settings,partTypes, resultsPerPage, jsonDownloader, responseDeserializer, apiUrlFormatter);
        }

        public static ApiRequest<TItem, TSettings> Create<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return Create<TItem, TSettings>(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<TItem>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Activities.Activity, ActivityApiRequestSettings> Create(ActivityApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Activities.Activity>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Captions.Caption, CaptionApiRequestSettings> Create(CaptionApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Captions.Caption>(), new ApiUrlFormatter());
        }


        public static ApiRequest<Entities.PlaylistItems.PlaylistItem, PlaylistItemsApiRequestSettings> Create(PlaylistItemsApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.PlaylistItems.PlaylistItem>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Playlists.Playlist, PlaylistApiRequestSettings> Create(PlaylistApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Playlists.Playlist>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Search.SearchResult, SearchApiRequestSettings> Create(SearchApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Search.SearchResult>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Subscriptions.Subscription, SubscriptionApiRequestSettings> Create(SubscriptionApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Subscriptions.Subscription>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.VideoCategories.VideoCategory, VideoCategoryApiRequestSettings> Create(VideoCategoryApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.VideoCategories.VideoCategory>(), new ApiUrlFormatter());
        }

        public static ApiRequest<Entities.Videos.Video, VideoApiRequestSettings> Create(VideoApiRequestSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Videos.Video>(), new ApiUrlFormatter());
        }

        

        
    }

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