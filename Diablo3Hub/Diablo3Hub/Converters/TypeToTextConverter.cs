using System;
using System.Diagnostics;
using Windows.UI.Xaml.Data;

namespace Diablo3Hub.Converters
{
    public class TypeToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Models.Type == false) return null;
            var type = (Models.Type) value;
            string returnValue;
            Debug.WriteLine($"TypeToTextConverter {type.Id}");
            switch (type.Id)
            {
                case "Helm":
                case "Helm_Necromancer":
                    //언어 리소스 반환
                    returnValue = "머리";
                    break;
                case "Legs":
                    returnValue = "다리";
                    break;
                case "Shoulders":
                    returnValue = "어깨";
                    break;
                case "Amulet":
                    returnValue = "목";
                    break;
                case "Ring":
                    returnValue = "손가락";
                    break;
                case "Gloves":
                    returnValue = "손";
                    break;
                case "Quiver":
                    returnValue = "가슴";
                    break;
                case "Bracers":
                    returnValue = "손목";
                    break;
                case "Boots":
                    returnValue = "발";
                    break;
                case "GenericBelt":
                    returnValue = "허리";
                    break;
                default:
                    //무기
                    returnValue = type.TwoHanded ? "양손 무기" : "한손 무기";
                    break;
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}