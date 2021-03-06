﻿using System.Collections.Generic;

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
        /// The liveStreamingDetails object contains metadata about a live video broadcast. The object will only be present in a video resource if the video is an upcoming, live, or completed live broadcast.
        /// </summary>
        public LiveStreamingDetails LiveStreamingDetails { get; set; }
    }
}