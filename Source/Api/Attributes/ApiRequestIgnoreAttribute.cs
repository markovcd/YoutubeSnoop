using System;

namespace YoutubeSnoop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestIgnoreAttribute : Attribute { }
}