using System;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Api.Attributes
{
    /// <summary>
    /// Specify this attribute over Settings overriden class property to provide custom converter of type IApiRequestConverter (IApiRequestConverter.Convert will be called instead of ToString when formatting API request URL). 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ToStringConvertAttribute : Attribute
    {
        public IToStringConverter Converter { get; }

        public ToStringConvertAttribute(Type converterType)
        {
            Converter = (IToStringConverter)Activator.CreateInstance(converterType);
        }
    }
}