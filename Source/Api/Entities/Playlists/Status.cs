using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Playlists
{
    public class Status
    {
        /// <summary>
        /// The playlist's privacy status.
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }
    }
}