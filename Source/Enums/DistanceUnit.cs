using System.ComponentModel;

namespace YoutubeSnoop.Enums
{
    public enum DistanceUnit
    {
        [Description("m")]
        Meter,
        [Description("km")]
        Kilometer,
        [Description("ft")]
        Feet,
        [Description("mi")]
        Mile
    }
}