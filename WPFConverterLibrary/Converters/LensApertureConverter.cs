using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    /// <summary>
    ///     Converts a lens aperture from a decimal into a human-preferred string (e.g. 1.8 becomes F1.8)
    ///     Based on sample:
    ///     https://github.com/microsoft/WPF-Samples/blob/master/Sample%20Applications/PhotoViewerDemo/LensApertureConverter.cs
    /// </summary>
    public class LensApertureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return $"F{value:##.0}";
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, CultureInfo culture)
        {
            if (!string.IsNullOrEmpty((string)value))
            {
                return decimal.Parse(((string)value).Substring(1));
            }
            return null;
        }
    }
}
