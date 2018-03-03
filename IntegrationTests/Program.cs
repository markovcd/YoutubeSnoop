using System;
using YoutubeSnoop;
using YoutubeSnoop.Entities.Search;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Settings;

namespace IntegrationTests
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var settings = new SearchApiRequestSettings
            {
                Order = SearchOrder.Date,
                PublishedAfter = new DateTime(2018, 02, 27),
                RegionCode = CountryCode.Pl,
                Query = "planking"
            };

            var api = new ApiRequest<SearchResult, SearchApiRequestSettings>(settings, PartType.Snippet);
            var response = api.Response;
        }
    }
}