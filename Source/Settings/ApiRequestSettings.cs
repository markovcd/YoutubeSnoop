using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using YoutubeSnoop.Arguments;
using YoutubeSnoop.Enums;
using YoutubeSnoop.Interfaces;
using YoutubeSnoop.Attributes;

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
