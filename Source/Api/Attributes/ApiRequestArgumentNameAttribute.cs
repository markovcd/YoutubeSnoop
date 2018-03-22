using System;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Specify this attribute over ApiRequestSettings overriden class property to specify explicit API argument name. Useful in case when property name is different that actual argument name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestArgumentNameAttribute : Attribute
    {
        public string Name { get; }

        public ApiRequestArgumentNameAttribute(string name)
        {
            Name = name;
        }
    }
}