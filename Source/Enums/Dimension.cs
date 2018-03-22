using Newtonsoft.Json;
using System.ComponentModel;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Enums
{
    [JsonConverter(typeof(DimensionConverter))]
    public enum Dimension
    {
        [Description("any")]
        Any,

        [Description("2d")]
        TwoDimensional,

        [Description("3d")]
        ThreeDimensional
    }
}