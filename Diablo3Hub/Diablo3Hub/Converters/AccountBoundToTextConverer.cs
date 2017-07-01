using System;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    public class AccountBoundToTextConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool == false) return null;
            var accountBound = (bool) value;
            return accountBound ? "계정 귀속" : "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}