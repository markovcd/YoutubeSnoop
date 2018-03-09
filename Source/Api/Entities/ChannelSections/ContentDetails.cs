using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.ChannelSections
{
    public class ContentDetails
    {
        /// <summary>
        /// A list of one or more playlist IDs that are featured in a channel section. You must specify a list of playlist IDs if the channelSection resource's snippet.type property is either singlePlaylist or multiplePlaylists, and this property should not be specified for other types of sections. If the type is singlePlaylist, this list must specify exactly one playlist ID.
        /// </summary>
        public IList<string> Playlists { get; set; }

        /// <summary>
        /// A list of one or more channel IDs that are featured in a channel section. You must specify a list of channel IDs if the channelSection resource's snippet.type property is multipleChannels, and this property should not be specified for other types of sections. You cannot include your own channel in the list.
        /// </summary>
        public IList<string> Channels { get; set; }
    }
}