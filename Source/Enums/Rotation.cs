namespace YoutubeSnoop.Enums
{
    public enum Rotation
    {
        /// <summary>
        /// The video does not need to be rotated.
        /// </summary>
        None,

        /// <summary>
        /// The video needs to be rotated 90 degrees clockwise.
        /// </summary>
        Clockwise,

        /// <summary>
        /// The video needs to be rotated 90 degrees counter-clockwise.
        /// </summary>
        CounterClockwise,

        /// <summary>
        /// The video needs to be rotated in some other, non-trivial way.
        /// </summary>
        Other,

        /// <summary>
        /// The video needs to be rotated upside down.
        /// </summary>
        UpsideDown
    }
}