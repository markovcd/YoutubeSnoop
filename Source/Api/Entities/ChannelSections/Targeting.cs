using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Targeting
    {
        /// <summary>
        /// A list of application languages for which the channel section is visible. Use the i18nLanguages.list method to retrieve a list of application languages that YouTube supports.
        /// </summary>
        public IList<string> Languages { get; set; }

        /// <summary>
        /// A list of content regions where the channel section is visible. Use the i18nRegions.list method to retrieve a list of content regions that YouTube supports.
        /// </summary>
        public IList<string> Regions { get; set; }

        /// <summary>
        /// A list of ISO 3166-1 alpha-2 country codes where the channel section is visible.
        /// </summary>
        public IList<string> Countries { get; set; }
    }
}