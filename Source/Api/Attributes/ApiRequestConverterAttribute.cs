using System;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Specify this attribute over ApiRequestSettings overriden class property to provide custom converter of type IApiRequestConverter (IApiRequestConverter.Convert will be called instead of ToString when formatting API request URL). 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestConvertAttribute : Attribute
    {
        public IApiRequestConverter Converter { get; }

        public ApiRequestConvertAttribute(Type converterType)
        {
            Converter = (IApiRequestConverter)Activator.CreateInstance(converterType);
        }
    }
}