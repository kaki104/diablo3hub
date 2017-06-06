using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Diablo3Hub.Converters
{
    internal class DisplayColorToColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string == false) return null;
            var displayColor = (string) value;
            var colorBrush = new SolidColorBrush(Colors.White);
            switch (displayColor)
            {
                case "blue":
                    //매직
                    colorBrush = new SolidColorBrush(Colors.DodgerBlue);
                    break;
                case "yellow":
                    //레어 #FF4E4014, Color.FromArgb(255, 116, 100, 24)
                    colorBrush = new SolidColorBrush(Colors.Yellow);
                    break;
                case "orange":
                    //유닉
                    colorBrush = new SolidColorBrush(Colors.Orange);
                    break;
                case "green":
                    //세트
                    colorBrush = new SolidColorBrush(Colors.LawnGreen);
                    break;
            }
            return colorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
