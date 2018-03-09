using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ChannelSection : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel section.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the channel section, such as its type, display style, and title.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object contains details about the channel section's content, such as a list of playlists or channels featured in the section.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The localizations object encapsulates translations of the channel section's metadata. The key is a string that contains a BCP-47 language code.
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }

        /// <summary>
        /// The targeting object contains targeting settings for the channel section. Note that a user must meet all of the targeting settings for a channel section to be visible. The following examples help to explain the behavior:
        /// </summary>
        /// <remarks>
        /// If the targeting.languages[] property value is ['en','es'], the channel section will be visible to users who have selected English or Spanish as their application language.
        /// If the targeting.languages[] property value is ['en','es'], and the targeting.regions[] property value is ['CA','FR'], the channel section will be visible to users in Canada and France who also have selected English or Spanish as their application language.
        /// </remarks>
        public Targeting Targeting { get; set; }
    }
}
