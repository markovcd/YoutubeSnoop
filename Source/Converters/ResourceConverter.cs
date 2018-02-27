using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
{
    public class ResourceConverter : JsonConverter<IResource>
    {
        public override IResource ReadJson(JsonReader reader, Type objectType, IResource existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                var kind = ResourceKindConverter.Convert(item["kind"].Value<string>());
                var json = item.ToString();

                return ResourceFactory.Deserialize(kind, json);
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, Interfaces.IResource value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}