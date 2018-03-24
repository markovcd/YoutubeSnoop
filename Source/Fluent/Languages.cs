using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeLanguages Languages(string languageCode = "")
        {
            return new YoutubeLanguages(new I18nLanguageApiRequestSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}