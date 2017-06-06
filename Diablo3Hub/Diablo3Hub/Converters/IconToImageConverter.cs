using System;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    internal class IconToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string == false) return null;
            var icon = (string) value;
            var type = "items";
            var size = "large";
            if (parameter is string)
            {
                //파라메터에 따라 skill인 경우 사이즈도 여러가지로 줄 수 있게
            }
            var url = $"http://media.blizzard.com/d3/icons/{type}/{size}/{icon}.png";
            return url;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}