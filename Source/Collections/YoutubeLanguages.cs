using YoutubeSnoop.Api;
using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Api.Settings;

namespace YoutubeSnoop
{
    public sealed class YoutubeLanguages : YoutubeCollection<YoutubeLanguage, I18nLanguage, I18nLanguageApiRequestSettings>
    {
        public YoutubeLanguages(IApiRequest<I18nLanguage, I18nLanguageApiRequestSettings> request) : base(request)
        {
        }
    }
}