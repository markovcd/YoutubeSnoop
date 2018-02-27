using System;

namespace YoutubeSnoop.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    sealed class ApiResponseMappingAttribute : Attribute
    {
        public Type EntityType { get; }

        public ApiResponseMappingAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}