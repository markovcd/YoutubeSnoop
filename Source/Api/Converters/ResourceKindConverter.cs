using Newtonsoft.Json;
using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Converters
{
    public class ResourceKindConverter : OneWayJsonConverter<ResourceKind>
    {
        public override ResourceKind ReadJson(JsonReader reader, Type objectType, ResourceKind existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader?.TokenType == JsonToken.String)
            {
                return Extensions.ParseResourceKind(reader.Value.ToString());
            }

            throw new InvalidOperationException();
        }
    }
}