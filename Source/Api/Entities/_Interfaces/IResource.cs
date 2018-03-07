using Newtonsoft.Json;
using YoutubeSnoop.Api.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Entities
{
    [JsonConverter(typeof(ResourceIdConverter))]
    public interface IResource
    {
        ResourceKind Kind { get; }
    }
}