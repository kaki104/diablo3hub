using System;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Diablo3Hub.Services.SettingsServices;
using Diablo3Hub.Views;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public SettingsPartViewModel SettingsPartViewModel { get; } = new SettingsPartViewModel();
        public AboutPartViewModel AboutPartViewModel { get; } = new AboutPartViewModel();
    }

    public class SettingsPartViewModel : ViewModelBase
    {
        private readonly SettingsService _settings;
        private string _BusyText = "Please wait...";

        private DelegateCommand _ShowBusyCommand;

        public SettingsPartViewModel()
        {
            if (DesignMode.DesignModeEnabled)
            {
                // designtime
            }
            else
            {
                _settings = SettingsService.Instance;
            }
        }

        public bool ShowHamburgerButton
        {
            get => _settings.ShowHamburgerButton;
            set
            {
                _settings.ShowHamburgerButton = value;
                RaisePropertyChanged();
            }
        }

        public bool IsFullScreen
        {
            get => _settings.IsFullScreen;
            set
            {
                _settings.IsFullScreen = value;
                RaisePropertyChanged();
                ShowHamburgerButton = !value;
            }
        }

        public bool UseShellBackButton
        {
            get => _settings.UseShellBackButton;
            set
            {
                _settings.UseShellBackButton = value;
                RaisePropertyChanged();
            }
        }

        public bool UseLightThemeButton
        {
            get => _settings.AppTheme.Equals(ApplicationTheme.Light);
            set
            {
                _settings.AppTheme = value ? ApplicationTheme.Light : ApplicationTheme.Dark;
                RaisePropertyChanged();
            }
        }

        public string BusyText
        {
            get => _BusyText;
            set
            {
                Set(ref _BusyText, value);
                _ShowBusyCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand ShowBusyCommand
            => _ShowBusyCommand ?? (_ShowBusyCommand = new DelegateCommand(async () =>
            {
                Busy.SetBusy(true, _BusyText);
                await Task.Delay(5000);
                Busy.SetBusy(false);
            }, () => !string.IsNullOrEmpty(BusyText)));
    }

    public class AboutPartViewModel : ViewModelBase
    {
        public Uri Logo => Package.Current.Logo;

        public string DisplayName => Package.Current.DisplayName;

        public string Publisher => Package.Current.PublisherDisplayName;

        public string Version
        {
            get
            {
                var v = Package.Current.Id.Version;
                return $"{v.Major}.{v.Minor}.{v.Build}.{v.Revision}";
            }
        }

        public Uri RateMe => new Uri("http://aka.ms/template10");
    }
}