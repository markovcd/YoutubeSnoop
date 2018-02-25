using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace YoutubeSnoop.Entities.Converters
{
    class ResourceIdConverter : JsonConverter<Interfaces.IResourceId>
    {

        public override Interfaces.IResourceId ReadJson(JsonReader reader, Type objectType, Interfaces.IResourceId existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject item = JObject.Load(reader);

                var kind = ResourceKindConverter.Convert(item["kind"].Value<string>());

                switch (kind)
                {
                    case ResourceKind.Video:
                        return new VideoResourceId { Kind = kind, VideoId = item["videoId"].Value<string>() };
                    case ResourceKind.Playlist:
                        return new PlaylistResourceId { Kind = kind, PlaylistId = item["playlistId"].Value<string>() };
                    case ResourceKind.Channel:
                        return new ChannelResourceId { Kind = kind, ChannelId = item["channelId"].Value<string>() };
                    default:
                        throw new InvalidOperationException();
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
