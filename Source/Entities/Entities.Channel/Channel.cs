using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class Channel : ISnippetResponse<ChannelSnippet>
    {
        public string Etag { get; set; }
        public string Id { get; set; }

        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public IDictionary<string, TitleDescription> Localizations { get; set; }
        public ChannelSnippet Snippet { get; set; }
        public ChannelContentDetails ContentDetails { get; set; }
        public ChannelContentOwnerDetails ContentOwnerDetails { get; set; }
        public ChannelStatistics Statistics { get; set; }
        public ChannelTopicDetails TopicDetails { get; set; }
        public ChannelStatus Status { get; set; }
        public ChannelBrandingSettings BrandingSettings { get; set; }

    }
}