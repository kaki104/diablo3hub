using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    /// <summary>
    /// 배틀 테그 상세 페이지 뷰모델
    /// </summary>
    public class BattleTagDetailPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public BattleTagDetailPageViewModel()
        {
            
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
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
                //평범한 네비게이션
                var result = await ApiHelper.Instance.GetCareerProfileAsync(battleTag.Tag);
                if (result == null) return;

            }
        }
    }
}
