using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class SearchResult : ISnippetResponse<SearchSnippet>
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }

        [JsonConverter(typeof(ResourceIdConverter))]
        public IResource Id { get; set; }

        public SearchSnippet Snippet { get; set; }
    }
}