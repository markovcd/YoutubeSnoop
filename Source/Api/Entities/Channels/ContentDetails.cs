namespace YoutubeSnoop.Api.Entities.Channels
{
    public class ContentDetails
    {
        /// <summary>
        /// The relatedPlaylists object is a map that identifies playlists associated with the channel, such as the channel's uploaded videos or liked videos. You can retrieve any of these playlists using the playlists.list method.
        /// </summary>
        public RelatedPlaylists RelatedPlaylists { get; set; }
    }
}