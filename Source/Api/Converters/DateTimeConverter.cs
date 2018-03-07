using System;
using System.Xml;

namespace YoutubeSnoop.Api.Converters
{
    public class DateTimeConverter : IApiRequestConverter
    {
        public string Convert(object value)
        {
            if (value == null) return null;
            return XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.Utc);
        }
    }
}