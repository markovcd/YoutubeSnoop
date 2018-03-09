using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class ProcessingDetails
    {
        /// <summary>
        /// The video's processing status. This value indicates whether YouTube was able to process the video or if the video is still being processed.
        /// </summary>
        public ProcessingStatus? ProcessingStatus { get; set; }

        /// <summary>
        /// The processingProgress object contains information about the progress YouTube has made in processing the video. The values are really only relevant if the video's processing status is processing.
        /// </summary>
        public ProcessingProgress ProcessingProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ProcessingFailureReason? ProcessingFailureReason { get; set; }

        /// <summary>
        /// This value indicates whether file details are available for the uploaded video. You can retrieve a video's file details by requesting the fileDetails part in your videos.list() request.
        /// </summary>
        public string FileDetailsAvailability { get; set; }

        /// <summary>
        /// This value indicates whether the video processing engine has generated suggestions that might improve YouTube's ability to process the the video, warnings that explain video processing problems, or errors that cause video processing problems. You can retrieve these suggestions by requesting the suggestions part in your videos.list() request.
        /// </summary>
        public string ProcessingIssuesAvailability { get; set; }

        /// <summary>
        /// This value indicates whether keyword (tag) suggestions are available for the video. Tags can be added to a video's metadata to make it easier for other users to find the video. You can retrieve these suggestions by requesting the suggestions part in your videos.list() request.
        /// </summary>
        public string TagSuggestionsAvailability { get; set; }

        /// <summary>
        /// This value indicates whether video editing suggestions, which might improve video quality or the playback experience, are available for the video. You can retrieve these suggestions by requesting the suggestions part in your videos.list() request.
        /// </summary>
        public string EditorSuggestionsAvailability { get; set; }

        /// <summary>
        /// This value indicates whether thumbnail images have been generated for the video.
        /// </summary>
        public string ThumbnailsAvailability { get; set; }
    }
}