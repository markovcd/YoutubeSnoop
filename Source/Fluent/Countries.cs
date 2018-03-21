using YoutubeSnoop.Api.Entities.I18nRegions;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCountries Countries(string languageCode = "")
        {
            var settings = new I18nRegionApiRequestSettings { Hl = languageCode };
            var request = DefaultRequest<I18nRegion, I18nRegionApiRequestSettings>(settings, new[] { PartType.Snippet });
            return new YoutubeCountries(request);
        }
    }
}