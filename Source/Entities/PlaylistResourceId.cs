using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class PlaylistResourceId : Interfaces.IResourceId
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string PlaylistId { get; set; }
    }
}
