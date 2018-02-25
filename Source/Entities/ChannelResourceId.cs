using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class ChannelResourceId : Interfaces.IResourceId
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string ChannelId { get; set; }
    }
}
