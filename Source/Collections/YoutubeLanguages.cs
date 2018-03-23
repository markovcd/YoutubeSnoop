using System.Collections.Generic;
using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Api.Settings;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public sealed class YoutubeLanguages : YoutubeCollection<YoutubeLanguage, I18nLanguage, I18nLanguageApiRequestSettings>
    {
        public YoutubeLanguages(IApiRequest<I18nLanguage, I18nLanguageApiRequestSettings> request) : base(request)
        {
        }

        public YoutubeLanguages(I18nLanguageApiRequestSettings settings = null, IEnumerable<PartType> partTypes = null, int resultsPerPage = 20)
            : base(settings, partTypes, resultsPerPage)
        {
        }
    }
}