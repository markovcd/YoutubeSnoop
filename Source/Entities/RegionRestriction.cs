using System.Collections.Generic;

namespace YoutubeSnoop.Entities
{
    public class RegionRestriction
    {
        public IList<string> Allowed { get; set; }
        public IList<string> Blocked { get; set; }
    }
}