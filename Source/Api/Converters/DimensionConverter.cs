using Newtonsoft.Json;
using System;
using System.Linq;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Converters
{
    public class DimensionConverter : OneWayJsonConverter<Dimension>
    {
        public override Dimension ReadJson(JsonReader reader, Type objectType, Dimension existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var s = reader.Value.ToString();

                return Enum.GetValues(typeof(Dimension)).Cast<Dimension>().First(d => s.Equals(d.GetDescription()));
            }

            throw new InvalidOperationException();
        }
    }
}
