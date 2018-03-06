using System;
using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Entities.I18nLanguages;
using YoutubeSnoop.Entities.I18nRegions;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;

        private static IJsonDownloader GetDefaultJsonDownloader()
        {
            return new JsonDownloader();
        }

        private static IResponseDeserializer<TItem> DefaultDeserializer<TItem>() where TItem : IResponse
        {
            return new ResponseDeserializer<TItem>();
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

        public static YoutubeLanguages Languages(string languageCode = "")
        {
            var settings = new I18nLanguageApiRequestSettings { Hl = languageCode };
            var request = DefaultRequest<I18nLanguage, I18nLanguageApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeLanguages(request);
        }

        public static YoutubeCountries Countries(string languageCode = "")
        {
            var settings = new I18nRegionApiRequestSettings { Hl = languageCode };
            var request = DefaultRequest<I18nRegion, I18nRegionApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeCountries(request);
        }
    }
}
