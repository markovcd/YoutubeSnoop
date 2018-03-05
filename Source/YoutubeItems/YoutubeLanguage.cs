using YoutubeSnoop.Entities.I18nLanguages;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

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
            Item = language;

            Kind = Item.Kind;
            Id = Item.Id;
            LanguageCode = Item.Snippet.Hl;
            LanguageName = Item.Snippet.Name;
        }

        public YoutubeLanguage(string languageCode, string languageName)
        {
            Kind = ResourceKind.I18nLanguage;
            Id = LanguageCode = languageCode;
            LanguageName = languageName;
        }
    }
}