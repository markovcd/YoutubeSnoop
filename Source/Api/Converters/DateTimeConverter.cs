using System;
using System.Xml;

namespace YoutubeSnoop.Api.Converters
{
    public class DateTimeConverter : ToStringConverter<DateTime?>
    {
        public override string Convert(DateTime? value)
        {
            if (value == null) return null;
            return XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.Utc);
        }
    }
}