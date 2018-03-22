using System;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Specify this attribute over ApiRequestSettings overriden class property in order to ignore it in API request.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestIgnoreAttribute : Attribute { }
}