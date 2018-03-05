using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Attributes;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Settings
{
    public abstract class ApiRequestSettings : IApiRequestSettings
    {
        [ApiRequestIgnore]
        public abstract RequestType RequestType { get; }

        public IApiRequestSettings DeepClone()
        {
            var type = GetType();

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                 .Where(p => !p.IsDefined(typeof(ApiRequestIgnoreAttribute)));

            var cloned = Activator.CreateInstance(type);

            foreach (var property in properties)
            {
                var value = property.GetValue(this);
                property.SetValue(cloned, value);
            }

            return (IApiRequestSettings)cloned;
        }

        public IEnumerable<ApiArgument> GetArguments()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => !p.IsDefined(typeof(ApiRequestIgnoreAttribute)));

            foreach (var property in properties)
            {
                var converter = property.GetCustomAttribute<ApiRequestConverterAttribute>(true)?.Converter;

                var name = property.GetCustomAttribute<ApiRequestArgumentNameAttribute>(true)?.Name ?? property.Name.ToCamelCase();

                var valueObject = property.GetValue(this);

                var value = converter == null ?
                    valueObject?.ToString() :
                    converter.Convert(valueObject);

                if (valueObject is Enum) value = value.ToCamelCase();

                if (value != null) yield return new ApiArgument(name, value);
            }
        }
    }
}