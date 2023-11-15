using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;

namespace ErrorTemplates
{
    public class ErrorsToMessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder result = new StringBuilder();

            ReadOnlyCollection<ValidationError> errors = value as ReadOnlyCollection<ValidationError>;

            if (errors != null)
            {
                foreach (var item in errors)
                {
                    if (item.ErrorContent != null)
                        result.Append(item.ErrorContent.ToString());
                }
            }

            return result.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
