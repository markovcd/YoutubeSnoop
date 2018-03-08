using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Targeting
    {
        public IList<string> Languages { get; set; }
        public IList<string> Regions { get; set; }
        public IList<string> Countries { get; set; }
    }
}