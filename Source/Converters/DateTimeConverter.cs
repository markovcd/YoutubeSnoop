using System;
using System.Xml;
using YoutubeSnoop.Interfaces;

namespace YoutubeSnoop.Converters
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