using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class Video : IResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }
        public string Id { get; set; }
        public VideoSnippet Snippet { get; set; }
        public VideoContentDetails ContentDetails { get; set; }
        public VideoStatistics Statistics { get; set; }
        public VideoStatus Status { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public VideoPlayer Player { get; set; }
        public VideoTopicDetails TopicDetails { get; set; }
        public VideoRecordingDetails RecordingDetails { get; set; }
        public VideoFileDetails FileDetails { get; set; }
        public VideoProcessingDetails ProcessingDetails { get; set; }
        public VideoSuggestions Suggestions { get; set; }
        public VideoLiveStreamingDetails LiveStreamingDetails { get; set; }
    }
}