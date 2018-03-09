﻿using System;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;

        private static IJsonDownloader GetDefaultJsonDownloader()
        {
            return new JsonDownloader();
        }

        private static IPagedResponseDeserializer<TItem> DefaultDeserializer<TItem>() where TItem : IResponse
        {
            return new PagedResponseDeserializer<TItem>();
        }

        private static IApiUrlFormatter<TSettings> DefaultUrlFormatter<TSettings>() where TSettings : IApiRequestSettings
        {
            return new ApiUrlFormatter<TSettings>();
        }

        public static IApiRequest<TItem, TSettings> DefaultRequest<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return new ApiRequest<TItem, TSettings>(settings, partTypes, ResultsPerPage, GetDefaultJsonDownloader(), DefaultDeserializer<TItem>(), DefaultUrlFormatter<TSettings>());
        }

        public static IApiRequest<TItem, TSettings> Clone<TItem, TSettings>(this IApiRequest<TItem, TSettings> request, IEnumerable<PartType> partTypes)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return new ApiRequest<TItem, TSettings>((TSettings)request.Settings.Clone(), partTypes, ResultsPerPage, GetDefaultJsonDownloader(), DefaultDeserializer<TItem>(), DefaultUrlFormatter<TSettings>());
        }

        public static IApiRequest<TItem, TSettings> Clone<TItem, TSettings>(this IApiRequest<TItem, TSettings> request)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return request.Clone(request.PartTypes);
        }

        public static IApiRequest<TItem, TSettings> RequestPart<TItem, TSettings>(this IApiRequest<TItem, TSettings> request, PartType partType)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return request.Clone(request.PartTypes.Concat(new[] { partType }).Distinct());
        }

        public static IYoutubeItem Details(this IResource resourceId)
        {
            var id = resourceId.Id();

            switch (resourceId.Kind)
            {
                case ResourceKind.Video: return Video(id);
                case ResourceKind.Playlist: return Playlist(id);
                case ResourceKind.Channel: return Channel(id);
                default: throw new InvalidOperationException();
            }
        }  
    }
}