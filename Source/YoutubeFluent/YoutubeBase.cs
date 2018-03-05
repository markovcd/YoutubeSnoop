using System.Collections.Generic;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop
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
    }
}
