using Newtonsoft.Json;
using System;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Converters
{
    internal class ResourceKindConverter : JsonConverter<ResourceKind>
    {
        public static ResourceKind Convert(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return ResourceKind.None;

            s = s.Split('#')[1];

            if (!Enum.TryParse<ResourceKind>(s, true, out var result)) return ResourceKind.None;

            return result;
        }

        public override ResourceKind ReadJson(JsonReader reader, Type objectType, ResourceKind existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var kind = Convert(reader.Value.ToString());
                return kind;
            }

            throw new InvalidOperationException();
        }

        public override void WriteJson(JsonWriter writer, ResourceKind value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}