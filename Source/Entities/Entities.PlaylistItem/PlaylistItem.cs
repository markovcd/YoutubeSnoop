using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    public class PlaylistItem : ISnippetResponse<PlaylistItemSnippet>
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }
        public string Id { get; set; }
        public PlaylistItemSnippet Snippet { get; set; }
        public PlaylistItemContentDetails ContentDetails { get; set; }
        public PlaylistItemStatus Status { get; set; }
    }
}