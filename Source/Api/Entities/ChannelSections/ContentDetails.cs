using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ContentDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<string> Playlists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<string> Channels { get; set; }
    }
}