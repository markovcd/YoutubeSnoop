using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class TagSuggestion
    {
        /// <summary>
        ///
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        public IList<string> CategoryRestricts { get; set; }
    }
}