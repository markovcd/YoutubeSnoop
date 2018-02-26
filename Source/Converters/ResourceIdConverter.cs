using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
{
    internal class ResourceIdConverter : JsonConverter<IResourceId>
    {
        public override IResourceId ReadJson(JsonReader reader, Type objectType, Interfaces.IResourceId existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                var kind = ResourceKindConverter.Convert(item["kind"].Value<string>());
                var s = item.ToString();

                switch (kind)
                {
                    case ResourceKind.Video: return JsonConvert.DeserializeObject<VideoResourceId>(s);
                    case ResourceKind.Playlist: return JsonConvert.DeserializeObject<PlaylistResourceId>(s);
                    case ResourceKind.Channel: return JsonConvert.DeserializeObject<ChannelResourceId>(s);
                    default: throw new InvalidOperationException();
                }
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, Interfaces.IResourceId value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}