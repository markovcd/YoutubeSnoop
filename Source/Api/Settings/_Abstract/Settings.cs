using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using YoutubeSnoop.Api.Attributes;
using YoutubeSnoop.Api.Arguments;
using YoutubeSnoop.Enums;

namespace YoutubeSnoop.Api
{
    /// <summary>
    /// Override this class to specify settings structure for API request.
    /// </summary>
    public abstract class Settings : ISettings
    {
        [IgnoreProperty]
        public abstract RequestType RequestType { get; }

        public IEnumerable<Argument> GetArguments()
        {
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(p => !p.IsDefined(typeof(IgnorePropertyAttribute)));

            foreach (var property in properties)
            {
                var converter = property.GetCustomAttribute<ToStringConvertAttribute>(true)?.Converter;

                var name = property.GetCustomAttribute<ArgumentNameAttribute>(true)?.Name ?? property.Name.ToCamelCase();

                var valueObject = property.GetValue(this);

                var value = converter == null ?
                    valueObject?.ToString() :
                    converter.Convert(valueObject);

                if (valueObject is Enum) value = value.ToCamelCase();

                if (value != null) yield return new Argument(name, value);
            }
        }
    }
}