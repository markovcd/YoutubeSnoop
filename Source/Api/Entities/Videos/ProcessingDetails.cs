namespace YoutubeSnoop.Api.Entities.Videos
{
    public class ProcessingDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string ProcessingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ProcessingProgress ProcessingProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProcessingFailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FileDetailsAvailability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProcessingIssuesAvailability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TagSuggestionsAvailability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EditorSuggestionsAvailability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ThumbnailsAvailability { get; set; }
    }
}