using System;

namespace YoutubeSnoop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ApiResponseMappingAttribute : Attribute
    {
        public Type EntityType { get; }

        public ApiResponseMappingAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}