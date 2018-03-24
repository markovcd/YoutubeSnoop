using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public static class Request
    {
        public static Request<TItem, TSettings> Create<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer, IUrlFormatter apiUrlFormatter)
            where TItem : class, IResponse
            where TSettings : class, ISettings
        {
            return new Request<TItem, TSettings>(settings, partTypes, resultsPerPage, jsonDownloader, responseDeserializer, apiUrlFormatter);
        }

        public static Request<TItem, TSettings> Create<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            where TItem : class, IResponse
            where TSettings : class, ISettings
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<TItem>(), new UrlFormatter());
        }

        public static Request<Entities.Activities.Activity, ActivitySettings> Create(ActivitySettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Activities.Activity>(), new UrlFormatter());
        }

        public static Request<Entities.Captions.Caption, CaptionSettings> Create(CaptionSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Captions.Caption>(), new UrlFormatter());
        }

        public static Request<Entities.Channels.Channel, ChannelSettings> Create(ChannelSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Channels.Channel>(), new UrlFormatter());
        }

        public static Request<Entities.ChannelSections.ChannelSection, ChannelSectionSettings> Create(ChannelSectionSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.ChannelSections.ChannelSection>(), new UrlFormatter());
        }

        public static Request<Entities.Comments.Comment, CommentSettings> Create(CommentSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Comments.Comment>(), new UrlFormatter());
        }

        public static Request<Entities.CommentThreads.CommentThread, CommentThreadSettings> Create(CommentThreadSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.CommentThreads.CommentThread>(), new UrlFormatter());
        }

        public static Request<Entities.GuideCategories.GuideCategory, GuideCategorySettings> Create(GuideCategorySettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.GuideCategories.GuideCategory>(), new UrlFormatter());
        }

        public static Request<Entities.I18nLanguages.I18nLanguage, I18nLanguageSettings> Create(I18nLanguageSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.I18nLanguages.I18nLanguage>(), new UrlFormatter());
        }

        public static Request<Entities.I18nRegions.I18nRegion, I18nRegionSettings> Create(I18nRegionSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.I18nRegions.I18nRegion>(), new UrlFormatter());
        }

        public static Request<Entities.PlaylistItems.PlaylistItem, PlaylistItemSettings> Create(PlaylistItemSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.PlaylistItems.PlaylistItem>(), new UrlFormatter());
        }

        public static Request<Entities.Playlists.Playlist, PlaylistSettings> Create(PlaylistSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Playlists.Playlist>(), new UrlFormatter());
        }

        public static Request<Entities.Search.SearchResult, SearchSettings> Create(SearchSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Search.SearchResult>(), new UrlFormatter());
        }

        public static Request<Entities.Subscriptions.Subscription, SubscriptionSettings> Create(SubscriptionSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Subscriptions.Subscription>(), new UrlFormatter());
        }

        public static Request<Entities.VideoCategories.VideoCategory, VideoCategorySettings> Create(VideoCategorySettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.VideoCategories.VideoCategory>(), new UrlFormatter());
        }

        public static Request<Entities.Videos.Video, VideoSettings> Create(VideoSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
        {
            return Create(settings, partTypes, resultsPerPage, new JsonDownloader(), new PagedResponseDeserializer<Entities.Videos.Video>(), new UrlFormatter());
        }   
    }

    /// <summary>
    /// Core functionality class of YoutubeSnoop. 
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <typeparam name="TSettings"></typeparam>
    public class Request<TItem, TSettings> : IRequest<TItem, TSettings>
        where TItem : class, IResponse
        where TSettings : class, ISettings
    {
        private readonly IJsonDownloader _jsonDownloader;
        private readonly IPagedResponseDeserializer<TItem> _responseDeserializer;
        private readonly IUrlFormatter _apiUrlFormatter;

        private TItem _firstItem;
        public TItem FirstItem => _firstItem ?? (_firstItem = Items.FirstOrDefault());

        public IEnumerable<TItem> Items { get; }
        public TSettings Settings { get; }
        public int ResultsPerPage { get; }

        public IEnumerable<PartType> PartTypes { get; }

        public Request(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer, IUrlFormatter apiUrlFormatter)
        {
            _jsonDownloader = jsonDownloader;
            _responseDeserializer = responseDeserializer;
            _apiUrlFormatter = apiUrlFormatter;

            ResultsPerPage = resultsPerPage;
            Settings = settings ?? Activator.CreateInstance<TSettings>();
            PartTypes = partTypes == null || !partTypes.Any() ? new[] { PartType.Snippet } : partTypes;

            Items = this.SelectMany(i => i.Items);
        }

        public IPagedResponse<TItem> Deserialize(string pageToken = null)
        {
            return Deserialize(_apiUrlFormatter, _jsonDownloader, _responseDeserializer, Settings, PartTypes, ResultsPerPage, pageToken);
        }

        public static IPagedResponse<TItem> Deserialize(IUrlFormatter apiUrlFormatter, IJsonDownloader jsonDownloader, IPagedResponseDeserializer<TItem> responseDeserializer,
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