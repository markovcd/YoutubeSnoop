using Newtonsoft.Json;
using YoutubeSnoop.Converters;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Interfaces
{
    [JsonConverter(typeof(ResourceIdConverter))]
    public interface IResource
    {
        ResourceKind Kind { get; }
    }
}