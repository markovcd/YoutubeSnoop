using System;

namespace YoutubeSnoop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public sealed class EntityMappingAttribute : Attribute
    {
        public Type EntityType { get; }

        public EntityMappingAttribute(Type entityType)
        {
            EntityType = entityType;
        }
    }
}