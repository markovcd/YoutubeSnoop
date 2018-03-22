using System;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Not currently used.
    /// </summary>
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