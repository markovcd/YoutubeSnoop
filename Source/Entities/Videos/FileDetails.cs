using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Videos
{
    public class FileDetails
    {
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public string FileType { get; set; }
        public string Container { get; set; }
        public long? DurationMs { get; set; }
        public long? BitrateBps { get; set; }
        public string CreationTime { get; set; }
        public IList<VideoStream> VideoStreams { get; set; }
        public IList<AudioStream> AudioStreams { get; set; }
    }
}