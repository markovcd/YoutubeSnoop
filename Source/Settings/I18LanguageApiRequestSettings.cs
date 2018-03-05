using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class I18LanguageApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.I18nLanguages;

        public LanguageCode Hl { get; set; }
    }
}