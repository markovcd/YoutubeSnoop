using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities
{
    class Playlist : IResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }
        public string Id { get; set; }
        public PlaylistSnippet Snippet { get; set; }
        public PlaylistContentDetails ContentDetails { get; set; }
        public PlaylistStatus Status { get; set; }
        public PlaylistPlayer Player { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
    }
}
