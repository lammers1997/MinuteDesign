using System;
using System.Globalization;
using System.Windows.Data;

namespace MinuteDesign.MVVM.Converters
{
    public class UserInputToLocationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double userInput)
            {
                // Convert user input by dividing it by 10
                return userInput / 10;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

}
