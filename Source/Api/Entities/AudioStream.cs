namespace YoutubeSnoop.Api.Entities
{
    public class AudioStream
    {
        /// <summary>
        /// The number of audio channels that the stream contains.
        /// </summary>
        public int? ChannelCount { get; set; }

        /// <summary>
        /// The audio codec that the stream uses.
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// The audio stream's bitrate, in bits per second.
        /// </summary>
        public long? BitrateBps { get; set; }

        /// <summary>
        /// A value that uniquely identifies a video vendor. Typically, the value is a four-letter vendor code.
        /// </summary>
        public long? Vendor { get; set; }
    }
}