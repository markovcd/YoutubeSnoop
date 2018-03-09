namespace YoutubeSnoop.Enums
{
    /// <summary>
    /// The type of audio track associated with the caption track.
    /// </summary>
    public enum AudioTrackType
    {
        /// <summary>
        ///  This is the default value.
        /// </summary>
        Unknown,

        /// <summary>
        /// The caption track corresponds to an alternate audio track that includes commentary, such as directory commentary.
        /// </summary>
        Commentary,

        /// <summary>
        /// The caption track corresponds to an alternate audio track that includes additional descriptive audio.
        /// </summary>
        Descriptive,

        /// <summary>
        /// The caption track corresponds to the primary audio track for the video, which is the audio track normally associated with the video.
        /// </summary>
        Primary
    }
}