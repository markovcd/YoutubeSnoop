using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Status
    {
        /// <summary>
        /// Privacy status of the channel.
        /// </summary>
        public PrivacyStatus? PrivacyStatus { get; set; }

        /// <summary>
        /// Indicates whether the channel data identifies a user that is already linked to either a YouTube username or a Google+ account. A user that has one of these links already has a public YouTube identity, which is a prerequisite for several actions, such as uploading videos.
        /// </summary>
        public bool? IsLinked { get; set; }
    }
}