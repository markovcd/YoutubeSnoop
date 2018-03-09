using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class Targeting
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<string> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> Regions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> Countries { get; set; }
    }
}