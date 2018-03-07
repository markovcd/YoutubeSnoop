using System;
using YoutubeSnoop.Api.Converters;

namespace YoutubeSnoop.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class ApiRequestConverterAttribute : Attribute
    {
        public IApiRequestConverter Converter { get; }

        public ApiRequestConverterAttribute(Type converterType)
        {
            Converter = (IApiRequestConverter)Activator.CreateInstance(converterType);
        }
    }
}