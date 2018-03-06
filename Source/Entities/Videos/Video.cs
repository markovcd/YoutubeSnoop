using System.Collections.Generic;

namespace YoutubeSnoop.Entities.Videos
{
    public class Video : Response
    {
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Statistics Statistics { get; set; }
        public Status Status { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public Player Player { get; set; }
        public TopicDetails TopicDetails { get; set; }
        public RecordingDetails RecordingDetails { get; set; }
        public FileDetails FileDetails { get; set; }
        public ProcessingDetails ProcessingDetails { get; set; }
        public Suggestions Suggestions { get; set; }
        public LiveStreamingDetails LiveStreamingDetails { get; set; }
    }
}