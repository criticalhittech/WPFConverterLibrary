using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/JekPoint/Xceed.Wpf.Toolkit/blob/master/Src/Xceed.Wpf.Toolkit/Core/Converters/ColorToSolidColorBrushConverter.cs
    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
                return new SolidColorBrush((Color)value);
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
                return ((SolidColorBrush)value).Color;
            return value;
        }
    }
}
