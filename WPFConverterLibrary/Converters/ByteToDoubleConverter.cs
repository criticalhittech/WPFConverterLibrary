using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/microsoft/WPF-Samples/blob/master/Data%20Binding/Colors/ByteToDoubleConverter.cs
    public class ByteToDoubleConverter : IValueConverter
    {
        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            return System.Convert.ChangeType(o, typeof(double));
        }

        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            var d = (double)o;
            return (d < 0.0)
                ? (byte)0
                : (d > 255.0)
                    ? (byte)255
                    : System.Convert.ChangeType(o, typeof(byte));
        }
    }
}
