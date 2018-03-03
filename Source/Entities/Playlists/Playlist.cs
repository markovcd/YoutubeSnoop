using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.Playlists
{
    public class Playlist : IResponse
    {
        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Etag { get; set; }
        public string Id { get; set; }
        public Snippet Snippet { get; set; }
        public ContentDetails ContentDetails { get; set; }
        public Status Status { get; set; }
        public Player Player { get; set; }
        public IDictionary<string, TitleDescription> Localizations { get; set; }
    }
}
