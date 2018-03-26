using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace DemoApp.Converters
{
    class BooleanInvertConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new BooleanInvertConverter();
        }
    }
}
