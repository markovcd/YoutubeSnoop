namespace YoutubeSnoop.Enums
{
    /// <summary>
    /// The caption track's type.
    /// </summary>
    public enum CaptionType
    {
        /// <summary>
        /// A regular caption track. This is the default value.
        /// </summary>
        Standard,

        /// <summary>
        /// A caption track generated using automatic speech recognition.
        /// </summary>
        ASR,

        /// <summary>
        /// A caption track that plays when no other track is selected in the player. For example, a video that shows aliens speaking in an alien language might have a forced caption track to only show subtitles for the alien language.
        /// </summary>
        Forced
    }
}