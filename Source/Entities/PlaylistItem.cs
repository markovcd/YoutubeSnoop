using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class PlaylistItem : Interfaces.ISnippetResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string Etag { get; set; }
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
