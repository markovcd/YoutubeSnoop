using System;
using System.Xml;

namespace YoutubeSnoop.Api.Converters
{
    public class DateTimeConverter : ApiRequestConverter<DateTime?>
    {
        public override string Convert(DateTime? value)
        {
            if (value == null) return null;
            return XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.Utc);
        }
    }
}