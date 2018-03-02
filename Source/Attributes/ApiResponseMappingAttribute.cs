using System;

namespace YoutubeSnoop.Attributes
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