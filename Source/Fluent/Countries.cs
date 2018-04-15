using System.Collections.Generic;
using System.Linq;
using YoutubeSnoop.Api;

namespace YoutubeSnoop.Fluent
{
    public static partial class Youtube
    {
        public static IEnumerable<YoutubeCountry> TakePages(this YoutubeCountries countries, int pageCount)
        {
            return countries.Take(countries.ResultsPerPage.GetValueOrDefault(ResultsPerPage) * pageCount);
        }

        public static IEnumerable<YoutubeCountry> TakePage(this YoutubeCountries countries)
        {
            return countries.TakePages(1);
        }

        public static YoutubeCountries Countries(string languageCode = "")
        {
            return new YoutubeCountries(new I18nRegionSettings { Hl = languageCode }, null, ResultsPerPage);
        }
    }
}