using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class TagSuggestion
    {
        public string Tag { get; set; }
        public IList<string> CategoryRestricts { get; set; }
    }
}