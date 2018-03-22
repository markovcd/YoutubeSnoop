using System;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Not currently used.
    /// </summary>
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