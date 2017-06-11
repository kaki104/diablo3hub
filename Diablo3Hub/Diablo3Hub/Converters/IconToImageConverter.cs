using System;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    /// <summary>
    /// Icon을 이미지 uri로 반환
    /// https://github.com/kaki104/diablo3hub/wiki/Getting-image-data
    /// </summary>
    internal class IconToImageConverter : IValueConverter
    {
        /// <summary>
        /// 컨버트
        /// </summary>
        /// <param name="value">Icon</param>
        /// <param name="targetType"></param>
        /// <param name="parameter">[items|skills]|[[small|large]|[21,42,64]]</param>
        /// <param name="language"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string == false) return null;
            var icon = (string) value;
            var type = "items";
            var size = "large";
            var s = parameter as string;
            //파라메터에 따라 skill인 경우 사이즈도 여러가지로 줄 수 있게
            var part = s?.Split('|');
            if (part?.Length == 2)
            {
                type = part.First();
                size = part.Last();
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