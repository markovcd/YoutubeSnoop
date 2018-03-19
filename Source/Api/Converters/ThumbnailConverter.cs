using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api.Converters
{
    public class ThumbnailConverter : OneWayJsonConverter<Thumbnail>
    {
        public override Thumbnail ReadJson(JsonReader reader, Type objectType, Thumbnail existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                return new Thumbnail(item["url"].Value<string>(), item["width"]?.Value<int?>(), item["height"]?.Value<int?>());
            }

            return null;
        }
    }
}