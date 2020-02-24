using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Ported from a Xamarin IValueConverter sample:
    //https://github.com/CrossGeeks/UsefulConvertersSample/blob/master/UsefulConvertersSample/Converters/CollectionHasElementsConverter.cs
    public class HideEmptyCollectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;

            return ((IEnumerable<object>)value).Any() ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
