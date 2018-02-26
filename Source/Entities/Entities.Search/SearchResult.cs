using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class SearchResult : IResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public IResourceId Id { get; set; }

        public SearchSnippet Snippet { get; set; }
    }
}