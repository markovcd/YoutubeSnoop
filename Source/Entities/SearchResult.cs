using Newtonsoft.Json;
using YoutubeSnoop.Entities.Converters;

namespace YoutubeSnoop.Entities
{
    public class SearchResult : Interfaces.ISnippetResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }
        public string Etag { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public Interfaces.IResourceId Id { get; set; }
        public Snippet Snippet { get; set; }
    }
}
