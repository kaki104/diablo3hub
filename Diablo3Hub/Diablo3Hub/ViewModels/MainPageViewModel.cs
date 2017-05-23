using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Services;
using Diablo3Hub.Views;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Diablo3Hub.Models;

namespace Diablo3Hub.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _inputBattleTag;
        private string _inputHeroId;
        private string _value = "Gas";

        public MainPageViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                Value = "Designtime value";
            else
                Init();
        }

        public string Value
        {
            get => _value;
            set => Set(ref _value, value);
        }

        /// <summary>
        ///     입력한 배틀테그
        /// </summary>
        public string InputBattleTag
        {
            get => _inputBattleTag;
            set => Set(ref _inputBattleTag, value);
        }

        public ICommand CareerProfileCommand { get; set; }

        public ICommand HeroProfileCommand { get; set; }

        /// <summary>
        ///     입력한 히어로아이디
        /// </summary>
        public string InputHeroId
        {
            get => _inputHeroId;
            set => Set(ref _inputHeroId, value);
        }

        public IList<Hero> Heros { get; set; }

        /// <summary>
        ///     초기화
        /// </summary>
        private async void Init()
        {
            await ApiHelper.Instance.InitAsync();

            CareerProfileCommand = new DelegateCommand(async () =>
            {
                var result = await ApiHelper.Instance.GetCareerProfileAsync(InputBattleTag);
                if (result == null) return;
                var cls = result.Heroes.First().Class;
            });

            HeroProfileCommand = new DelegateCommand(async () =>
            {
                var result = await ApiHelper.Instance.GetHeroProfileAsync(InputBattleTag, InputHeroId);
                if (result == null) return;
            });
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
                Value = suspensionState[nameof(Value)]?.ToString();
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
                suspensionState[nameof(Value)] = Value;
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void GotoDetailsPage()
        {
            NavigationService.Navigate(typeof(DetailPage), Value);
        }

        public void GotoSettings()
        {
            NavigationService.Navigate(typeof(SettingsPage), 0);
        }

        public void GotoPrivacy()
        {
            NavigationService.Navigate(typeof(SettingsPage), 1);
        }

        public void GotoAbout()
        {
            NavigationService.Navigate(typeof(SettingsPage), 2);
        }
    }
}