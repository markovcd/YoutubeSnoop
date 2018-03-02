using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class ResourceIdPlaylist : IResource
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string PlaylistId { get; set; }
    }
}