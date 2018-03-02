using System;

namespace YoutubeSnoop.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class ApiResourceMappingAttribute : Attribute
    {
        public Type EntityType { get; }

        public ApiResourceMappingAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}
