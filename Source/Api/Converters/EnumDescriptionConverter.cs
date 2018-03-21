using Newtonsoft.Json;
using System;
using System.Linq;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Converters
{
    public class EnumDescriptionConverter : OneWayJsonConverter<Dimension>, IApiRequestConverter
    {
        public string Convert(object value)
        {
            if (value == null) return null;

            var nullableType = Nullable.GetUnderlyingType(value.GetType());

            Enum e;
            if (nullableType == null && value is Enum) e = (Enum)value;
            else if (nullableType == typeof(Enum)) e = (Enum)Enum.Parse(nullableType, value.ToString());
            else throw new InvalidOperationException();

            return e.GetDescription();
        }

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