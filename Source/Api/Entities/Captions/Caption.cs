namespace YoutubeSnoop.Api.Entities.Captions
{
    public class Caption : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the caption track.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the caption.
        /// </summary>
        public Snippet Snippet { get; set; }
    }
}
