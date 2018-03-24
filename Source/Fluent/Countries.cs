using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCountries Countries(string languageCode = "")
        {
            return new YoutubeCountries(new I18nRegionApiRequestSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}