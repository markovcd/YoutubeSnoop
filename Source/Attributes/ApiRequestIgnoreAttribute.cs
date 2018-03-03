using System;

namespace YoutubeSnoop.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestIgnoreAttribute : Attribute { }
}