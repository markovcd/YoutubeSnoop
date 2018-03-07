using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class TagSuggestion
    {
        public string Tag { get; set; }
        public IList<string> CategoryRestricts { get; set; }
    }
}