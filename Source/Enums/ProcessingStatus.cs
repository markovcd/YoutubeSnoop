namespace YoutubeSnoop.Enums
{
    public enum ProcessingStatus
    {
        /// <summary>
        /// Video processing has failed. See ProcessingFailureReason.
        /// </summary>
        Failed,

        /// <summary>
        /// Video is currently being processed. See ProcessingProgress.
        /// </summary>
        Processing,

        /// <summary>
        /// Video has been successfully processed.
        /// </summary>
        Succeeded,

        /// <summary>
        /// Processing information is no longer available.
        /// </summary>
        Terminated
    }
}