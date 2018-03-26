using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using YoutubeSnoop.Api.Entities;
using YoutubeSnoop.Enums;

namespace DemoApp.Converters
{
    class ThumbnailsToImageSourceConverter : MarkupExtension, IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value == null || !(value is IReadOnlyDictionary<ThumbnailSize, Thumbnail>)) return null;

                var size = parameter == null ? ThumbnailSize.Default : (ThumbnailSize)parameter;
                var thumbnail = ((IReadOnlyDictionary<ThumbnailSize, Thumbnail>)value)[size];

                var url = new Uri(thumbnail.Url);
                var image = new BitmapImage(url);
                return image;
            }
            catch 
            { }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new InvalidOperationException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new ThumbnailsToImageSourceConverter();
        }
    }
}
