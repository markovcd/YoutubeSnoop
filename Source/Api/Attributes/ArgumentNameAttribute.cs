using System;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Specify this attribute over Settings overriden class property to specify explicit API argument name. Useful in case when property name is different that actual argument name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ArgumentNameAttribute : Attribute
    {
        public string Name { get; }

        public ArgumentNameAttribute(string name)
        {
            Name = name;
        }
    }
}