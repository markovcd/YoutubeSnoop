using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    public sealed class ChannelSectionSettings : Settings
    {
        public override RequestType RequestType => RequestType.ChannelSections;

        /// <summary>
        /// Specifies a YouTube channel ID. If a request specifies a value for this parameter, the API will only return the specified channel's sections.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of IDs that uniquely identify the channelSection resources that are being retrieved. In a channelSection resource, the id property specifies the section's ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Instructs the API to retrieve localized resource metadata for a specific application language that the YouTube website supports. The parameter value must be a language code included in the list returned by the i18nLanguages.list method.
        /// </summary>
        public string Hl { get; set; }
    }
}