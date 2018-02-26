using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class VideoSuggestions
    {
        public IList<string> ProcessingErrors { get; set; }
        public IList<string> ProcessingWarnings { get; set; }
        public IList<string> ProcessingHints { get; set; }
        public IList<TagSuggestion> TagSuggestions { get; set; }
        public IList<string> EditorSuggestions { get; set; }
    }
}