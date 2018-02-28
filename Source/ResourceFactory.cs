using Newtonsoft.Json;
using System;
using System.Reflection;
using YoutubeSnoop.Attributes;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Entities;

namespace YoutubeSnoop
{
    public static class ResourceFactory
    {
        public static IResource Deserialize(ResourceKind kind, string json)
        {
            FieldInfo fieldInfo = kind.GetType().GetField(kind.ToString());
            if (fieldInfo == null) throw new InvalidOperationException();

            var resourceAttribute = fieldInfo.GetCustomAttribute<ApiResourceMappingAttribute>();
            if (resourceAttribute != null) return (IResource)JsonConvert.DeserializeObject(json, resourceAttribute.EntityType);

            var responseAttribute = fieldInfo.GetCustomAttribute<ApiResponseMappingAttribute>();
            if (responseAttribute == null) throw new InvalidOperationException();

            var responseType = typeof(Response<>).MakeGenericType(new[] { responseAttribute.EntityType });
            return (IResponse)JsonConvert.DeserializeObject(json, responseType);
        }

        public static TResource Deserialize<TResource>(string json) where TResource : IResource
        {
            return JsonConvert.DeserializeObject<TResource>(json);
        }

        public static Response<TItem> DeserializeResponse<TItem>(string json) where TItem : IResponse
        {
            var response = JsonConvert.DeserializeObject<Response<TItem>>(json);
            response.Json = json;
            return response;
        }
    }
}
