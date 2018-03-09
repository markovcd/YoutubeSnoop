namespace YoutubeSnoop.Enums
{
    /// <summary>
    /// The reason that YouTube failed to process the caption track. 
    /// </summary>
    public enum CaptionFailureReason
    {
        /// <summary>
        /// YouTube failed to process the uploaded caption track.
        /// </summary>
        ProcessingFailed,

        /// <summary>
        /// The caption track's format was not recognized.
        /// </summary>
        UnknownFormat,

        /// <summary>
        /// The caption track's format is not supported.
        /// </summary>
        UnsupportedFormat
    }
}