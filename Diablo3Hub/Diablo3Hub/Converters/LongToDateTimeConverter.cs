using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    /// <summary>
    ///     API로 반환되는 Int 타입의 일자를 반환
    /// </summary>
    public class LongToDateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is long == false) return null;
            var i = (long) value;
            //var diff = DateTime.UtcNow.Add(-TimeSpan.FromTicks(i));
            //return diff.ToString(CultureInfo.CurrentCulture);
            return UnixTimeStampToDateTimeForNew(i).ToString(CultureInfo.CurrentCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        private DateTime UnixTimeStampToDateTimeForNew(long unixTimeStamp)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimeStamp);
            var dateTime = dateTimeOffset.DateTime.ToLocalTime();
            return dateTime;
        }
    }
}