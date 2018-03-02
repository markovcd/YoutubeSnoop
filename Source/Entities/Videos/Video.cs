using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Videos
{
    public class Video : ISnippetResponse<Snippet>
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }
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