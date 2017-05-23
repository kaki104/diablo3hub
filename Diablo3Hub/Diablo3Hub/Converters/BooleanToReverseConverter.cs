using System;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    public class BooleanToReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool?) value == false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}