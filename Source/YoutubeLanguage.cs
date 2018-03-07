using YoutubeSnoop.Api.Entities.I18nLanguages;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop
{
    public class YoutubeLanguage : IYoutubeItem
    {
        public ResourceKind Kind { get; }
        public string Id { get; }
        public I18nLanguage Item { get; }
        public string LanguageCode { get; }
        public string LanguageName { get; }

        public YoutubeLanguage(I18nLanguage language)
        {
            if (language == null) return;

            Item = language;
            Kind = language.Kind;
            Id = language.Id;
            LanguageCode = language.Snippet.Hl;
            LanguageName = language.Snippet.Name;
        }

        public YoutubeLanguage(string languageCode, string languageName)
        {
            Kind = ResourceKind.I18nLanguage;
            Id = LanguageCode = languageCode;
            LanguageName = languageName;
        }
    }
}