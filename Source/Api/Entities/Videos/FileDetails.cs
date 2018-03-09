using System;
using System.Collections.Generic;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class FileDetails
    {
        /// <summary>
        /// The uploaded file's name. This field is present whether a video file or another type of file was uploaded.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The uploaded file's size in bytes. This field is present whether a video file or another type of file was uploaded.
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// The uploaded file's type as detected by YouTube's video processing engine. Currently, YouTube only processes video files, but this field is present whether a video file or another type of file was uploaded.
        /// </summary>
        public FileType? FileType { get; set; }

        /// <summary>
        /// The uploaded video file's container format.
        /// </summary>
        public string Container { get; set; }

        /// <summary>
        /// The length of the uploaded video in milliseconds.
        /// </summary>
        public long? DurationMs { get; set; }

        /// <summary>
        /// The uploaded video file's combined (video and audio) bitrate in bits per second.
        /// </summary>
        public long? BitrateBps { get; set; }

        /// <summary>
        /// The date and time when the uploaded video file was created.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// A list of video streams contained in the uploaded video file. Each item in the list contains detailed metadata about a video stream.
        /// </summary>
        public IList<VideoStream> VideoStreams { get; set; }

        /// <summary>
        /// A list of audio streams contained in the uploaded video file. Each item in the list contains detailed metadata about an audio stream.
        /// </summary>
        public IList<AudioStream> AudioStreams { get; set; }
    }
}