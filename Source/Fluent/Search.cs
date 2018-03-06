using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeSearch Search(SearchApiRequestSettings settings = null)
        {
            var request = DefaultRequest<SearchResult, SearchApiRequestSettings>(settings ?? new SearchApiRequestSettings(), new[] { PartType.Snippet });
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Search(string query = null)
        {
            return Search(new SearchApiRequestSettings { Query = query });
        }

        public static YoutubeSearch ForCountry(this YoutubeSearch search, YoutubeCountry country)
        {
            var request = search.Request.Clone();
            request.Settings.RegionCode = country.CountryCode;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch ForChannelId(this YoutubeSearch search, string id)
        {
            var request = search.Request.Clone();
            request.Settings.ChannelId = id;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch OrderBy(this YoutubeSearch search, SearchOrder order)
        {
            var request = search.Request.Clone();
            request.Settings.Order = order;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch PublishedAfter(this YoutubeSearch search, DateTime d)
        {
            var request = search.Request.Clone();
            request.Settings.PublishedAfter = d;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch PublishedBefore(this YoutubeSearch search, DateTime d)
        {
            var request = search.Request.Clone();
            request.Settings.PublishedBefore = d;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch Type(this YoutubeSearch search, ResourceKind t)
        {
            var request = search.Request.Clone();
            request.Settings.Type = t;
            return new YoutubeSearch(request);
        }

        public static YoutubeSearch SafeSearch(this YoutubeSearch search, SafeSearch s)
        {
            var request = search.Request.Clone();
            request.Settings.SafeSearch = s;
            return new YoutubeSearch(request);
        }

 

    }
}
