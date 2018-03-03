using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Channels
{
    public class Channel : IResponse
    {
        public string Etag { get; set; }
        public string Id { get; set; }

        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public ContentOwnerDetails ContentOwnerDetails { get; set; }
        public Statistics Statistics { get; set; }
        public TopicDetails TopicDetails { get; set; }
        public Status Status { get; set; }
        public BrandingSettings BrandingSettings { get; set; }

    }
}