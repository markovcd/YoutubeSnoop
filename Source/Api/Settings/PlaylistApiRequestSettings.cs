using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    public sealed class PlaylistApiRequestSettings : ApiRequestSettings
    {
        public override RequestType RequestType => RequestType.Playlists;

        /// <summary>
        /// Indicates that the API should only return the specified channel's playlists.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Specifies a comma-separated list of the YouTube playlist ID(s) for the resource(s) that are being retrieved. In a playlist resource, the id property specifies the playlist's YouTube playlist ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Instructs the API to retrieve localized resource metadata for a specific application language that the YouTube website supports. The parameter value must be a language code included in the list returned by the i18nLanguages.list method.
        /// </summary>
        /// <remarks>
        /// If localized resource details are available in that language, the resource's snippet.localized object will contain the localized values. However, if localized details are not available, the snippet.localized object will contain resource details in the resource's default language.
        /// </remarks>
        public string Hl { get; set; }
    }
}