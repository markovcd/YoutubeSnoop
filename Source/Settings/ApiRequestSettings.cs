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

        public IEnumerable<ApiArgument> GetArguments()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => !p.IsDefined(typeof(ApiRequestIgnoreAttribute)));

            foreach (var property in properties)
            {
                var converter = property.GetCustomAttribute<ApiRequestConverterAttribute>(true)?.Converter;

                var name = property.GetCustomAttribute<ApiRequestArgumentNameAttribute>(true)?.Name ?? property.Name.ToCamelCase();

                var value = converter == null ?
                    property.GetValue(this)?.ToString() :
                    converter.Convert(property.GetValue(this));

                if (value != null) yield return new ApiArgument(name, value);
            }
        }
    }
}