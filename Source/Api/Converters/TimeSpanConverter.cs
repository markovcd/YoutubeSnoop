using Newtonsoft.Json;
using System;
using System.Xml;

namespace YoutubeSnoop.Api.Converters
{
    public class TimeSpanConverter : OneWayJsonConverter<TimeSpan>
    {
        public override TimeSpan ReadJson(JsonReader reader, Type objectType, TimeSpan existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader?.TokenType == JsonToken.String)
            {
                return XmlConvert.ToTimeSpan(reader.Value?.ToString());
            }

            throw new InvalidOperationException();
        }
    }
}