using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Diablo3Hub.Services
{
    /// <summary>
    /// FlyoutHelper를 이용해서 컨트롤에 프로퍼티 2개를 추가로 붙임
    /// </summary>
    public static class FlyoutHelper
    {
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.RegisterAttached("IsOpen", typeof(bool),
                typeof(FlyoutHelper), new PropertyMetadata(false, OnIsOpenPropertyChanged));

        public static readonly DependencyProperty ParentProperty =
            DependencyProperty.RegisterAttached("Parent", typeof(object),
                typeof(FlyoutHelper), new PropertyMetadata(null, OnParentPropertyChanged));

        public static void SetIsOpen(DependencyObject d, bool value)
        {
            d.SetValue(IsOpenProperty, value);
        }

        public static bool GetIsOpen(DependencyObject d)
        {
            return (bool) d.GetValue(IsOpenProperty);
        }

        public static void SetParent(DependencyObject d, object value)
        {
            d.SetValue(ParentProperty, value);
        }

        public static object GetParent(DependencyObject d)
        {
            return d.GetValue(ParentProperty);
        }

        private static void OnParentPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var flyout = d as Flyout;
            if (flyout == null) return;
            flyout.Opening += (s, args) => { flyout.SetValue(IsOpenProperty, true); };
            flyout.Closed += (s, args) => { flyout.SetValue(IsOpenProperty, false); };
        }

        private static void OnIsOpenPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var flyout = d as Flyout;
            var parent = d.GetValue(ParentProperty);
            if (flyout == null || parent == null) return;

            var newValue = (bool) e.NewValue;

            if (newValue)
                flyout.ShowAt(parent as FrameworkElement);
            else
                flyout.Hide();
        }
    }
}