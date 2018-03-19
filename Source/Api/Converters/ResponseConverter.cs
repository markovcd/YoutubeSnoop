using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Api.Entities;

namespace YoutubeSnoop.Api.Converters
{
    public class ResponseConverter : OneWayJsonConverter<IResponse>
    {
        public override IResponse ReadJson(JsonReader reader, Type objectType, IResponse existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader?.TokenType == JsonToken.StartObject)
            {
                var item = JObject.Load(reader);
                var kind = Extensions.ParseResourceKind(item["kind"]?.Value<string>());

                var s = item?.ToString();
                var t = kind.GetMappedResponse();

                return (IResponse)JsonConvert.DeserializeObject(s, t);
            }

            throw new InvalidOperationException();
        }
    }
}
