using System;

namespace YoutubeSnoop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ApiMappingAttribute : Attribute
    {
        public Type EntityType { get; }

        public ApiMappingAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}