using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeCountries Countries(string languageCode = "")
        {
            return new YoutubeCountries(new I18nRegionSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}