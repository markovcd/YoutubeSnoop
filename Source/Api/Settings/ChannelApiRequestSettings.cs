using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class ChannelApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Channels;

        /// <summary>
        /// Specifies a YouTube guide category, thereby requesting YouTube channels associated with that category.
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Specifies a YouTube username, thereby requesting the channel associated with that username.
        /// </summary>
        public string ForUsername { get; set; }

        /// <summary>
        /// Instructs the API to retrieve localized resource metadata for a specific application language that the YouTube website supports. The parameter value must be a language code included in the list returned by the i18nLanguages.list method.
        /// </summary>
        public string Hl { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of the YouTube channel ID(s) for the resource(s) that are being retrieved. In a channel resource, the id property specifies the channel's YouTube channel ID.
        /// </summary>
        public string Id { get; set; }
    }
}