using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class RegionRestriction
    {
        /// <summary>
        /// A list of region codes that identify countries where the video is viewable. If this property is present and a country is not listed in its value, then the video is blocked from appearing in that country. If this property is present and contains an empty list, the video is blocked in all countries.
        /// </summary>
        public IList<string> Allowed { get; set; }

        /// <summary>
        /// A list of region codes that identify countries where the video is blocked. If this property is present and a country is not listed in its value, then the video is viewable in that country. If this property is present and contains an empty list, the video is viewable in all countries.
        /// </summary>
        public IList<string> Blocked { get; set; }
    }
}