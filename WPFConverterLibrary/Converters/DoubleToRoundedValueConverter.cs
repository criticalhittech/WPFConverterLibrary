using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Ported from a Xamarin IValueConverter sample:
    //https://github.com/CrossGeeks/UsefulConvertersSample/blob/master/UsefulConvertersSample/Converters/DoubleToRoundedValueConverter.cs
    public class DoubleToRoundedValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val && val >= 1)
            {
                return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val && val > 0)
            {
                return decimal.Round((decimal)val, 2, MidpointRounding.AwayFromZero);
            }
            return value;
        }
    }
}
