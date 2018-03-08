using Newtonsoft.Json;
using YoutubeSnoop.Api.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    [JsonConverter(typeof(ResourceConverter))]
    public interface IResource
    {
        ResourceKind Kind { get; }
    }
}