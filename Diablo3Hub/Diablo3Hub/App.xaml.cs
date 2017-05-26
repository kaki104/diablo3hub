using System.Diagnostics;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Diablo3Hub.Services;
using Diablo3Hub.Services.SettingsServices;
using Diablo3Hub.Views;
using Template10.Common;
using Template10.Controls;

namespace Diablo3Hub
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki
    [Bindable]
    sealed partial class App : BootStrapper
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = e => new Splash(e);

            #region app settings

            // some settings must be set in app.constructor
            var settings = SettingsService.Instance;
            RequestedTheme = settings.AppTheme;
            CacheMaxDuration = settings.CacheMaxDuration;
            ShowShellBackButton = settings.UseShellBackButton;

            #endregion
            //현재 앱이 사용 중인 로컬 폴더 경로 출력 - DB 삭제 및 기타 용도로 사용할 때 필요
            Debug.WriteLine(ApplicationData.Current.LocalFolder.Path);
        }
        /// <summary>
        /// Shell 생성
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override UIElement CreateRootElement(IActivatedEventArgs e)
        {
            var service = NavigationServiceFactory(BackButton.Attach, ExistingContent.Exclude);
            return new ModalDialog
            {
                DisableBackButtonWhenModal = true,
                Content = new Shell(service),
                ModalContent = new Busy()
            };
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            // TODO: add your long-running task here

            //db 초기화
            await DBHelper.Instance.InitAsync();
            //API 초기화
            await ApiHelper.Instance.InitAsync();

            //MainPage로 네비게이션
            await NavigationService.NavigateAsync(typeof(MainPage));
        }
    }
}