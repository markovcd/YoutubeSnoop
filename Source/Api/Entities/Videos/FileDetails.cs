using System.Collections.Generic;

namespace YoutubeSnoop.Api.Entities.Videos
{
    public class FileDetails
    {
        /// <summary>
        /// 
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long? BitrateBps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<VideoStream> VideoStreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<AudioStream> AudioStreams { get; set; }
    }
}