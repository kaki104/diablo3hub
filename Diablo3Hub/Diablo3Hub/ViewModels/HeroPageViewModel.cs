using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.DesignDatas;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Diablo3Hub.Views;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class HeroPageViewModel : ViewModelBase
    {
        private HeroProfile _currentHeroProfile;
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public HeroPageViewModel()
        {
            if (DesignMode.DesignModeEnabled)
            {
                CurrentHeroProfile = HeroProfileData.GetHeroProfile();
            }
            else
            {
                Init();
            }
        }
        /// <summary>
        /// 초기화
        /// </summary>
        private void Init()
        {
            
        }

        /// <summary>
        ///     현재 히어로 프로파일
        /// </summary>
        public HeroProfile CurrentHeroProfile
        {
            get => _currentHeroProfile;
            set => Set(ref _currentHeroProfile, value);
        }
        /// <summary>
        /// 네비게이션
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> state)
        {
            if (parameter is string == false) return;
            //파라메터로 넘어온 배틀테그 만들고
            var para = JsonConvert.DeserializeObject<KeyValuePair<string, string>>(parameter.ToString());
            if (mode == NavigationMode.Back)
            {
                //네비게이션 백
            }
            else
            {
                Busy.SetBusy(true, "Please wait...");
                //평범한 네비게이션
                var result = await ApiHelper.Instance.GetHeroProfileAsync(para.Key, para.Value);
                if (result == null) goto ExitRtn;
                //제대로된 배틀테그라면..
                CurrentHeroProfile = result;

                ExitRtn:
                Busy.SetBusy(false);
            }
        }
    }
}



