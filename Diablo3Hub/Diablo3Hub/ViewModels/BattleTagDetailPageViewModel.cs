using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.DesignDatas;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Diablo3Hub.Views;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    /// <summary>
    ///     배틀 테그 상세 페이지 뷰모델
    /// </summary>
    public class BattleTagDetailPageViewModel : ViewModelBase
    {
        private CareerProfile _currentBattleTag;

        /// <summary>
        ///     기본 생성자
        /// </summary>
        public BattleTagDetailPageViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                CurrentBattleTag = CareerProfileData.GetCareerProfile();
            else
                Init();
        }

        /// <summary>
        ///     현재 배틀테그
        /// </summary>
        public CareerProfile CurrentBattleTag
        {
            get => _currentBattleTag;
            set => Set(ref _currentBattleTag, value);
        }

        /// <summary>
        ///     히어로 클릭 커맨드
        /// </summary>
        public ICommand ItemClickCommand { get; set; }

        private void Init()
        {
            ItemClickCommand = new DelegateCommand<object>(obj =>
            {
                var args = obj as ItemClickEventArgs;
                var item = args?.ClickedItem as Hero;
                if (item == null) return;

                //네비게이션 파라메터로 사용할 녀석 생성
                var para = new KeyValuePair<string, string>(CurrentBattleTag.BattleTag, item.Id.ToString());

                var serialPara = JsonConvert.SerializeObject(para);
                NavigationService.Navigate(typeof(HeroPage), serialPara);
            });
        }

        /// <summary>
        ///     네비게이션
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
            var battleTag = JsonConvert.DeserializeObject<BattleTag>(parameter.ToString());
            if (mode == NavigationMode.Back)
            {
                //네비게이션 백
            }
            else
            {
                Busy.SetBusy(true, "Please wait...");
                //평범한 네비게이션
                var result = await ApiHelper.Instance.GetCareerProfileAsync(battleTag.Tag);
                if (result == null) goto ExitRtn;
                if (string.IsNullOrEmpty(result.BattleTag))
                {
                    //배틀테그를 찾을 수 없었을 때
                    //배틀테그를 찾을 수 없다는 메시지 출력하고 CurrentBattleTag = null로 입력
                }
                else
                {
                    //제대로된 배틀테그라면..
                    CurrentBattleTag = result;
                }


                ExitRtn:
                Busy.SetBusy(false);
            }
        }
    }
}