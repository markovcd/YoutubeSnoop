namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Player
    {
        /// <summary>
        /// An /<iframe/> tag that embeds a player that plays the video.
        /// </summary>
        /// <remarks>
        /// If the API request to retrieve the resource specifies a value for the maxHeight and/or maxWidth parameters, the size of the embedded player is scaled to satisfy the maxHeight and/or maxWidth requirements.
        /// If the video's aspect ratio is unknown, the embedded player defaults to a 4:3 format.
        /// </remarks>
        public string EmbedHtml { get; set; }

        /// <summary>
        /// The height of the embedded player returned in the player.embedHtml property. This property is only returned if the request specified a value for the maxHeight and/or maxWidth parameters and the video's aspect ratio is known.
        /// </summary>
        public long? EmbedHeight { get; set; }

        /// <summary>
        /// The width of the embedded player returned in the player.embedHtml property. This property is only returned if the request specified a value for the maxHeight and/or maxWidth parameters and the video's aspect ratio is known.
        /// </summary>
        public long? EmbedWidth { get; set; }
    }
}