using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Settings
{
    public sealed class I18nLanguageApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.I18nLanguages;

        public string Hl { get; set; }
    }
}