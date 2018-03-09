namespace YoutubeSnoop.Api.Entities
{
    public class RelatedPlaylists
    {
        /// <summary>
        /// The ID of the playlist that contains the channel's liked videos.
        /// </summary>
        public string Likes { get; set; }

        /// <summary>
        /// The ID of the playlist that contains the channel's uploaded videos. 
        /// </summary>
        public string Uploads { get; set; }
    }
}