using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Suggestions
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<string> ProcessingErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> ProcessingWarnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> ProcessingHints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<TagSuggestion> TagSuggestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> EditorSuggestions { get; set; }
    }
}