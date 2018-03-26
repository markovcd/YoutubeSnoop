using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static YoutubeLanguages Languages(string languageCode = "")
        {
            return new YoutubeLanguages(new I18nLanguageSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}