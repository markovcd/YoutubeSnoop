namespace YoutubeSnoop.Enums
{
    public enum ProcessingFailureReason
    {
        /// <summary>
        /// Some other processing component has failed.
        /// </summary>
        Other,

        /// <summary>
        /// Video could not be sent to streamers.
        /// </summary>
        StreamingFailed,

        /// <summary>
        /// Content transcoding has failed.
        /// </summary>
        TranscodeFailed,

        /// <summary>
        /// File delivery has failed.
        /// </summary>
        UploadFailed
    }
}