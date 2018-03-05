using YoutubeSnoop.Entities.I18nLanguages;
using YoutubeSnoop.Settings;

namespace YoutubeSnoop
{
    public class YoutubeLanguages : YoutubeCollection<YoutubeLanguage, I18nLanguage, I18nLanguageApiRequestSettings>
    {
        public YoutubeLanguages(IApiRequest<I18nLanguage, I18nLanguageApiRequestSettings> request) : base(request) { }

        protected override YoutubeLanguage CreateItem(I18nLanguage response)
        {
            return new YoutubeLanguage(response);
        }
    }
}