using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Converters
{
    public class ResourceConverter : OneWayJsonConverter<IResource>
    {
        public override IResource ReadJson(JsonReader reader, Type objectType, IResource existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                var kind = Extensions.ParseResourceKind(item["kind"].Value<string>());
                var s = item.ToString();

                switch (kind)
                {
                    case ResourceKind.Video: return JsonConvert.DeserializeObject<ResourceVideo>(s);
                    case ResourceKind.Playlist: return JsonConvert.DeserializeObject<ResourcePlaylist>(s);
                    case ResourceKind.Channel: return JsonConvert.DeserializeObject<ResourceChannel>(s);
                    default: throw new InvalidOperationException();
                }
            }

            return null;
        }
    }

   
}