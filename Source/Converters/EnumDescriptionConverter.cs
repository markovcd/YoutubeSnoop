using System;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
{
    public class EnumDescriptionConverter : IApiRequestConverter
    {
        public string Convert(object value)
        {
            if (value == null) return null;

            var nullableType = Nullable.GetUnderlyingType(value.GetType());

            Enum e;
            if (nullableType == null && value is Enum) e = (Enum)value;
            else if (nullableType == typeof(Enum)) e = (Enum)Enum.Parse(nullableType, value.ToString());
            else throw new InvalidOperationException();

            return e.GetDescription();
        }
    }
}