using System;
using System.ComponentModel;
using System.Reflection;

namespace YoutubeSnoop
{
    public static class Extensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = fieldInfo.GetCustomAttribute<DescriptionAttribute>();
            return attribute.Description;
        }

        public static string ToCamelCase(this string value)
        {
            return value.Substring(0, 1).ToLower() + value.Substring(1);
        }

        public static string ToCamelCase(this Enum value)
        {
            return ToCamelCase(value.ToString());
        }
    }
}
