using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static IEnumerable<YoutubeLanguage> TakePages(this YoutubeLanguages languages, int pageCount)
        {
            return languages.Take(languages.ResultsPerPage.GetValueOrDefault(ResultsPerPage) * pageCount);
        }

        public static IEnumerable<YoutubeLanguage> TakePage(this YoutubeLanguages languages)
        {
            return languages.TakePages(1);
        }

        public static YoutubeLanguages Languages(string languageCode = "")
        {
            return new YoutubeLanguages(new I18nLanguageSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}