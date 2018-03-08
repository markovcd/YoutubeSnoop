using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class I18nRegionApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.I18nRegions;

        /// <summary>
        /// Specifies the language that should be used for text values in the API response. The default value is en_US.
        /// </summary>
        public string Hl { get; set; }
    }
}