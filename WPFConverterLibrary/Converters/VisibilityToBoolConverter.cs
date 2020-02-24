using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/microsoft/WPF-Samples/blob/master/Documents/Fixed%20Documents/DocumentSerialization/VisibilityToBoolConverter.cs
    public class VisibilityToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                Visibility visibilityToConvert = (Visibility)value;
                if ((visibilityToConvert == Visibility.Collapsed)
                    || (visibilityToConvert == Visibility.Hidden))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                bool boolToConvert = (bool)value;
                if (boolToConvert)
                {
                    return Visibility.Collapsed;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
            catch
            {
                return Visibility.Collapsed;
            }
        }
    }
}
