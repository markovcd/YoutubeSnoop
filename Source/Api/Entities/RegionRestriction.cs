using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities
{
    public class RegionRestriction
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<string> Allowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> Blocked { get; set; }
    }
}