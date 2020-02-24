using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Ported from a Xamarin IValueConverter sample:
    //https://github.com/CrossGeeks/UsefulConvertersSample/blob/master/UsefulConvertersSample/Converters/EmptyValueToBoolConverter.cs
    public class EmptyValueToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.IsNullOrEmpty($"{value}") ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
