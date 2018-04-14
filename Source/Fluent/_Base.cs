using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static int ResultsPerPage { get; set; } = 20;

        public static IEnumerable<TItem> TakePages<TCollection, TItem, TResponse, TSettings>(this TCollection collection, int pageCount) 
            where TCollection : YoutubeCollection<TItem, TResponse, TSettings>
            where TItem : IYoutubeItem
            where TResponse : class, IResponse
            where TSettings : Settings
        {
            return collection.Take(collection.ResultsPerPage.GetValueOrDefault(20) * pageCount);
        }

        public static IEnumerable<TItem> TakePage<TCollection, TItem, TResponse, TSettings>(this TCollection collection)
            where TCollection : YoutubeCollection<TItem, TResponse, TSettings>
            where TItem : IYoutubeItem
            where TResponse : class, IResponse
            where TSettings : Settings
        {
            return collection.TakePages<TCollection, TItem, TResponse, TSettings>(1);
        }
    }
}