using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Entities.I18nRegions
{
    public class I18nRegion : IResponse
    {
        public string Etag { get; set; }

        [JsonConverter(typeof(ResourceKindConverter))]
        public ResourceKind Kind { get; set; }

        public string Id { get; set; }

        public Snippet Snippet { get; set; }
    }
}
