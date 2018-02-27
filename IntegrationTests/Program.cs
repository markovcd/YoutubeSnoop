using System;
using System.Linq;
using YoutubeSnoop;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var settings = new SearchApiRequestSettings();
            settings.Order = SearchOrder.Date;
            settings.PublishedAfter = new DateTime(2018, 02, 27);
            settings.RegionCode = CountryCode.Pl;
            settings.Query = "planking";

            var api = new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, PartType.Snippet);
            var response = api.Response;
        }
    }
}