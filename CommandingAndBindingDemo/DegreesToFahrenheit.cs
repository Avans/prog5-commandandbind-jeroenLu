using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CommandingAndBindingDemo
{
    class DegreesToFahrenheit : IValueConverter

    {
        // Converts the temperature in C to Fahrenheit
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Math.Round((((double) value * 1.8) + 32), 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
