using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Settings.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api.Settings
{
    /// <summary>
    /// Override this class to specify settings structure for API request.
    /// </summary>
    public abstract class ApiRequestSettings : IApiRequestSettings
    {
        [ApiRequestIgnore]
        public abstract RequestType RequestType { get; }

        public IEnumerable<ApiArgument> GetArguments()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => !p.IsDefined(typeof(ApiRequestIgnoreAttribute)));

            foreach (var property in properties)
            {
                var converter = property.GetCustomAttribute<ApiRequestConvertAttribute>(true)?.Converter;

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