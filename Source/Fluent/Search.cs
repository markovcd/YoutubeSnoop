﻿using System;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeSearch Search(SearchApiRequestSettings settings = null)
        {
            return new YoutubeSearch(settings, null, ResultsPerPage);
        }

        public static YoutubeSearch Search(string query)
        {
            return Search(new SearchApiRequestSettings { Query = query });
        }

        public static YoutubeSearch ForCountry(this YoutubeSearch search, string regionCode)
        {
            var settings = search.Settings.Clone();
            settings.RegionCode = regionCode;
            return Search(settings);
        }

        public static YoutubeSearch ForChannelId(this YoutubeSearch search, string id)
        {
            var settings = search.Settings.Clone();
            settings.ChannelId = id;
            return Search(settings);
        }

        public static YoutubeSearch RelatedToVideoId(this YoutubeSearch search, string id)
        {
            var settings = search.Settings.Clone();
            settings.RelatedToVideoId = id;
            settings.Type = ResourceKind.Video;
            return Search(settings);
        }

        public static YoutubeSearch OrderBy(this YoutubeSearch search, SearchOrder order)
        {
            var settings = search.Settings.Clone();
            settings.Order = order;
            return Search(settings);
        }

        public static YoutubeSearch OrderByDate(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.Date);
        }
        public static YoutubeSearch OrderByRating(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.Rating);
        }
        public static YoutubeSearch OrderByRelevance(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.Relevance);
        }
        public static YoutubeSearch OrderByTitle(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.Title);
        }
        public static YoutubeSearch OrderByVideoCount(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.VideoCount);
        }
        public static YoutubeSearch OrderByViewCount(this YoutubeSearch search)
        {
            return search.OrderBy(SearchOrder.ViewCount);
        }

        public static YoutubeSearch PublishedAfter(this YoutubeSearch search, DateTime d)
        {
            var settings = search.Settings.Clone();
            settings.PublishedAfter = d;
            return Search(settings);
        }

        public static YoutubeSearch PublishedBefore(this YoutubeSearch search, DateTime d)
        {
            var settings = search.Settings.Clone();
            settings.PublishedBefore = d;
            return Search(settings);
        }

        public static YoutubeSearch OfType(this YoutubeSearch search, ResourceKind t)
        {
            if (t != ResourceKind.Video && t != ResourceKind.Playlist && t != ResourceKind.Channel) throw new InvalidOperationException();

            var settings = search.Settings.Clone();
            settings.Type = t;
            return Search(settings);
        }

        public static YoutubeSearch SafeSearch(this YoutubeSearch search, SafeSearch s)
        {
            var settings = search.Settings.Clone();
            settings.SafeSearch = s;
            return Search(settings);
        }
    }
}