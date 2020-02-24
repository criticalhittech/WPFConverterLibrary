using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Ported from a Xamarin IValueConverter sample: 
    //https://github.com/CrossGeeks/UsefulConvertersSample/blob/master/UsefulConvertersSample/Converters/ToUpperConverter.cs
    public class ToUpperConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var text = $"{value}";
            if (!string.IsNullOrEmpty(text))
                return text.ToUpper();

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
