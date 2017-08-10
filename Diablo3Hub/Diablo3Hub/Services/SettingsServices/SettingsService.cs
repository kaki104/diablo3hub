using System;
using Windows.UI.Xaml;
using Diablo3Hub.Views;
using Template10.Common;
using Template10.Services.SettingsService;
using Template10.Utils;

namespace Diablo3Hub.Services.SettingsServices
{
    public class SettingsService
    {
        private readonly ISettingsHelper _helper;

        private SettingsService()
        {
            _helper = new SettingsHelper();
        }

        public static SettingsService Instance { get; } = new SettingsService();

        public bool UseShellBackButton
        {
            get => _helper.Read(nameof(UseShellBackButton), true);
            set
            {
                _helper.Write(nameof(UseShellBackButton), value);
                BootStrapper.Current.NavigationService.GetDispatcherWrapper().Dispatch(() =>
                {
                    BootStrapper.Current.ShowShellBackButton = value;
                    BootStrapper.Current.UpdateShellBackButton();
                });
            }
        }
        /// <summary>
        /// 무조건 다크 테마만 적용되도록 수정
        /// </summary>
        public ApplicationTheme AppTheme
        {
            get => ApplicationTheme.Dark;
            set
            {
                _helper.Write(nameof(AppTheme), value.ToString());
                var frameworkElement = Window.Current.Content as FrameworkElement;
                if (frameworkElement != null)
                    frameworkElement.RequestedTheme = value.ToElementTheme();
                Shell.HamburgerMenu.RefreshStyles(value, true);
            }
        }

        public TimeSpan CacheMaxDuration
        {
            get => _helper.Read(nameof(CacheMaxDuration), TimeSpan.FromDays(2));
            set
            {
                _helper.Write(nameof(CacheMaxDuration), value);
                BootStrapper.Current.CacheMaxDuration = value;
            }
        }

        public bool ShowHamburgerButton
        {
            get => _helper.Read(nameof(ShowHamburgerButton), true);
            set
            {
                _helper.Write(nameof(ShowHamburgerButton), value);
                Shell.HamburgerMenu.HamburgerButtonVisibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public bool IsFullScreen
        {
            get => _helper.Read(nameof(IsFullScreen), false);
            set
            {
                _helper.Write(nameof(IsFullScreen), value);
                Shell.HamburgerMenu.IsFullScreen = value;
            }
        }
    }
}