using System.Collections.Generic;
using System.Linq;
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
        private IList<ItemDetail> _currentItems;

        /// <summary>
        ///     기본 생성자
        /// </summary>
        public HeroPageViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                CurrentHeroProfile = HeroProfileData.GetHeroProfile();
            else
                Init();
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
        ///     현재 히어로가 장비한 아이템들에 대한 상세 정보
        /// </summary>
        public IList<ItemDetail> CurrentItems
        {
            get => _currentItems;
            set => Set(ref _currentItems, value);
        }

        /// <summary>
        ///     초기화
        /// </summary>
        private void Init()
        {
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
            var para = JsonConvert.DeserializeObject<KeyValuePair<string, string>>(parameter.ToString());

            Busy.SetBusy(true, "Please wait...");
            //평범한 네비게이션
            var result = await ApiHelper.Instance.GetHeroProfileAsync(para.Key, para.Value);
            if (result == null) goto ExitRtn;

            var itemTasks = from item in result.Items.Equipments
                where item != null
                select ApiHelper.Instance.GetItemDetailAsync(item.TooltipParams);

            var itemResults = await Task.WhenAll(itemTasks);

            //제대로된 배틀테그라면..
            CurrentHeroProfile = result;

            //아이템들에 대한 상세 정보
            CurrentItems = itemResults.ToList();

            //기존 히어로 아이템 정보에 아이템 상세를 
            foreach (var itemD in CurrentItems)
            {
                var oItem = CurrentHeroProfile.Items.Equipments.FirstOrDefault(p => p.Id == itemD.Id);
                if (oItem != null)
                {
                    oItem.ItemDetail = itemD;
                }
            }

            //var setItemDetail = (from itemDetail in CurrentItems
            //    join item in CurrentHeroProfile.Items.Equipments
            //    on itemDetail.Id equals item.Id into joiner
            //    from j in joiner
            //    select j.ItemDetail = itemDetail).Count();

            ExitRtn:
            Busy.SetBusy(false);
        }
    }
}