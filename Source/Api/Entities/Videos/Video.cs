using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class Video : Response
    {
        /// <summary>
        /// The ID that YouTube uses to uniquely identify the video.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The snippet object contains basic details about the video, such as its title, description, and category.
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// The contentDetails object contains information about the video content, including the length of the video and an indication of whether captions are available for the video.
        /// </summary>
        public ContentDetails ContentDetails { get; set; }

        /// <summary>
        /// The statistics object contains statistics about the video.
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// The status object contains information about the video's uploading, processing, and privacy statuses.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// The localizations object contains translations of the video's metadata. The key is a string that contains a BCP-47 language code.
        /// </summary>
        public IDictionary<string, TitleDescription> Localizations { get; set; }

        /// <summary>
        /// The player object contains information that you would use to play the video in an embedded player.
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// The topicDetails object encapsulates information about topics associated with the video.
        /// </summary>
        /// <remarks>
        /// Important: See the definitions of the topicDetails.relevantTopicIds[] and topicDetails.topicIds[] properties as well as the revision history for more details about upcoming changes related to topic IDs.
        /// </remarks>
        public TopicDetails TopicDetails { get; set; }

        /// <summary>
        /// The recordingDetails object encapsulates information about the location, date and address where the video was recorded.
        /// </summary>
        public RecordingDetails RecordingDetails { get; set; }

        /// <summary>
        /// The fileDetails object encapsulates information about the video file that was uploaded to YouTube, including the file's resolution, duration, audio and video codecs, stream bitrates, and more. This data can only be retrieved by the video owner.
        /// </summary>
        /// <remarks>
        /// The fileDetails object will only be returned if the processingDetails.fileAvailability property has a value of available.
        /// </remarks>
        public FileDetails FileDetails { get; set; }

        /// <summary>
        /// The processingDetails object encapsulates information about YouTube's progress in processing the uploaded video file. The properties in the object identify the current processing status and an estimate of the time remaining until YouTube finishes processing the video. This part also indicates whether different types of data or content, such as file details or thumbnail images, are available for the video.
        /// </summary>
        /// <remarks>
        /// The processingProgress object is designed to be polled so that the video uploaded can track the progress that YouTube has made in processing the uploaded video file. This data can only be retrieved by the video owner.
        /// </remarks>
        public ProcessingDetails ProcessingDetails { get; set; }


        /// <summary>
        /// The liveStreamingDetails object contains metadata about a live video broadcast. The object will only be present in a video resource if the video is an upcoming, live, or completed live broadcast.
        /// </summary>
        public LiveStreamingDetails LiveStreamingDetails { get; set; }
    }
}