using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Snippet
    {
        /// <summary>
        /// The channel section's type.
        /// </summary>
        public ChannelSectionType? Type { get; set; }

        /// <summary>
        /// The format in which the channel section displays.
        /// </summary>
        public ChannelSectionStyle? Style { get; set; }

        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel that published the channel section.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// The section's title. You can only set the title of a channel section that has a snippet.type value of either multiplePlaylists or multipleChannels, and, in fact, you must specify a title when inserting or updating either of those types of sections. If you specify a title for other types of channel sections, the value will be ignored.
        /// </summary>
        /// <remarks>This property's value has a maximum length of 100 characters and may contain all valid UTF-8 characters except /< and />.</remarks>
        public string Title { get; set; }

        /// <summary>
        /// The section's position on the channel page. This property uses a 0-based index. A value of 0 identifies the first section that appears on the channel, a value of 1 identifies the second section, and so forth.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// The language of the text in the channelSection resource's snippet.title property.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// The snippet.localized object contains either a localized title for the channel section or the title in the default language for the channel section's metadata.
        /// </summary>
        /// <remarks>
        /// Localized text is returned if the channelSections.list request used the hl parameter to specify a language for which localized text should be returned and localized text is available in that language.
        /// Metadata for the default language is returned if an hl parameter value is not specified or a value is specified but localized metadata is not available for the specified language.
        /// </remarks>
        public TitleDescription Localized { get; set; } 
    }
}