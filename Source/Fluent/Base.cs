using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;

        //private static IJsonDownloader GetDefaultJsonDownloader()
        //{
        //    return new JsonDownloader();
        //}

        //private static IPagedResponseDeserializer<TItem> DefaultDeserializer<TItem>() where TItem : IResponse
        //{
        //    return new PagedResponseDeserializer<TItem>();
        //}

        //private static IApiUrlFormatter GetDefaultUrlFormatter()
        //{
        //    return new ApiUrlFormatter();
        //}

        //public static IApiRequest<TItem, TSettings> GetDefaultRequest<TItem, TSettings>(TSettings settings, IEnumerable<PartType> partTypes, int resultsPerPage = 20)
        //    where TItem : class, IResponse
        //    where TSettings : IApiRequestSettings
        //{
        //    return new ApiRequest<TItem, TSettings>(settings, partTypes, resultsPerPage, GetDefaultJsonDownloader(), DefaultDeserializer<TItem>(), GetDefaultUrlFormatter());
        //}

        public static IApiRequest<TItem, TSettings> Clone<TItem, TSettings>(this IApiRequest<TItem, TSettings> request, IEnumerable<PartType> partTypes)
            where TItem : class, IResponse
            where TSettings : IApiRequestSettings
        {
            return new ApiRequest<TItem, TSettings>((TSettings)request.Settings.Clone(), partTypes, ResultsPerPage, GetDefaultJsonDownloader(), DefaultDeserializer<TItem>(), GetDefaultUrlFormatter());
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
    }
}