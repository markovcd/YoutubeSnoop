using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ContentDetails
    {
        public IList<string> Playlists { get; set; }
        public IList<string> Channels { get; set; }
    }
}