using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/microsoft/WPF-Samples/blob/master/Data%20Binding/Colors/LuminanceToBrushConverter.cs
    public class LuminanceToBrushConverter : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            var luminance = (double)o;
            return (luminance < 0.5) ? Brushes.White : Brushes.Black;
        }

        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
