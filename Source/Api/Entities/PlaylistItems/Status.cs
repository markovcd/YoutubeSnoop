using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.PlaylistItems
{
    public class Status
    {
        /// <summary>
        /// The playlist item's privacy status. The channel that uploaded the video that the playlist item represents can set this value using either the videos.insert or videos.update method.
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }
    }
}