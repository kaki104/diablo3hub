using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    /// <summary>
    ///     파라메터에 데이터 반드시 필요
    ///     파마메터 구성 : 비교값|nor or rev, nor:정상 비교값과 같으면 보여주고, 아니면 숨기고, rev:nor과 반대 작용
    /// </summary>
    public class AnyDataToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var returnValue = Visibility.Collapsed;
            var data = value == null ? "" : value.ToString();
            var para = parameter as string;

            if (para == null) return returnValue;

            var split = para.Split('|');
            if (split.Length < 2) return returnValue;

            //스플릿으로 나눈 데이터들의 가장 마지막넘이 조건
            //그 이전 데이터들과 같은지 비교
            var checkList = split.Take(split.Length - 1).ToList();
            if (checkList.Contains(data))
                returnValue = split.Last() == "nor"
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            else
                returnValue = split.Last() == "nor"
                    ? Visibility.Collapsed
                    : Visibility.Visible;

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}