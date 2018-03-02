using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Entities;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
{
    public class ResourceIdConverter : OneWayJsonConverter<IResource>
    {
        public override IResource ReadJson(JsonReader reader, Type objectType, IResource existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                var kind = ResourceKindConverter.Parse(item["kind"].Value<string>());
                var s = item.ToString();

                switch (kind)
                {
                    case ResourceKind.Video: return JsonConvert.DeserializeObject<ResourceIdVideo>(s);
                    case ResourceKind.Playlist: return JsonConvert.DeserializeObject<ResourceIdPlaylist>(s);
                    case ResourceKind.Channel: return JsonConvert.DeserializeObject<ResourceIdChannel>(s);
                    default: throw new InvalidOperationException();
                }
            }

            return null;
        }
    }
}