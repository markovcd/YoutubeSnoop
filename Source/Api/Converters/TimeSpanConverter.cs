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
                var timeSpan = XmlConvert.ToTimeSpan(reader.Value?.ToString());
                return timeSpan;
            }

            throw new InvalidOperationException();
        }
    }
}