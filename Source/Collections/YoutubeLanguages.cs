using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeLanguages : YoutubeCollection<YoutubeLanguage, I18nLanguage, I18nLanguageSettings>
    {
        public YoutubeLanguages(I18nLanguageSettings settings, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}