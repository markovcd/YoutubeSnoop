using Newtonsoft.Json;
using System;

namespace YoutubeSnoop.Converters
{
    public abstract class OneWayJsonConverter<T> : JsonConverter<T>
    {
        public abstract override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer);

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Converter supports only one way conversion.");
        }
    }
}