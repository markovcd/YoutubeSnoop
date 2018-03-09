using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Channels
{
    public class Channel : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the channel.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The localizations object encapsulates translations of the channel's metadata. Keys are strings that contains a BCP-47 language code.
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the channel, such as its title, description, and thumbnail images.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object encapsulates information about the channel's content.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The contentOwnerDetails object encapsulates channel data that is relevant for YouTube Partners linked with the channel.
        /// </summary>
        public ContentOwnerDetails ContentOwnerDetails { get; set; }

        /// <summary>
        /// The statistics object encapsulates statistics for the channel.
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// The topicDetails object encapsulates information about topics associated with the channel.
        /// </summary>
        /// <remarks>
        /// Important: See the topicDetails.topicIds[] property definition and the revision history for more details about changes related to topic IDs.
        /// </remarks>
        public TopicDetails TopicDetails { get; set; }

        /// <summary>
        /// The status object encapsulates information about the privacy status of the channel.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// The brandingSettings object encapsulates information about the branding of the channel.
        /// </summary>
        public BrandingSettings BrandingSettings { get; set; }
    }
}