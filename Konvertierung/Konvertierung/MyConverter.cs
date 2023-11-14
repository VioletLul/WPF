using System;
using System.Windows.Data;

namespace Konvertierung
{
    public class MyConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            var valueFromSource = (string)value!;

            return valueFromSource switch
            {
                "Mr" => "Herr",
                "Mrs" => "Frau",
                _ => string.Empty
            };
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
