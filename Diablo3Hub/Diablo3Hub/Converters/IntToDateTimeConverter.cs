using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    /// <summary>
    ///     API로 반환되는 Int 타입의 일자를 반환
    /// </summary>
    public class IntToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is int == false) return null;
            var i = (int) value;
            var diff = DateTime.UtcNow.Add(-TimeSpan.FromTicks(i));
            return diff.ToString(CultureInfo.CurrentCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}