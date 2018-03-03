using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
{
    //public class ResourceConverter : OneWayJsonConverter<IResource>
    //{
    //    public override IResource ReadJson(JsonReader reader, Type objectType, IResource existingValue, bool hasExistingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.StartObject)
    //        {
    //            var item = JObject.Load(reader);
    //            var kind = ResourceKindConverter.Parse(item["kind"].Value<string>());
    //            var json = item.ToString();

    //            return ResourceFactory.Deserialize(kind, json);
    //        }

    //        return null;
    //    }
    //}
}