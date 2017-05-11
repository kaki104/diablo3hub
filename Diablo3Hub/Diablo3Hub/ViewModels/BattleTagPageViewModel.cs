using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Commons;
using Diablo3Hub.Models;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagPageViewModel : ViewModelBase
    {
        private IList<BattleTag> _battleTags;
        /// <summary>
        /// 배틀 테그 목록
        /// </summary>
        public IList<BattleTag> BattleTags
        {
            get { return _battleTags; }
            set { Set(ref _battleTags ,value); }
        }

        public BattleTagPageViewModel()
        {
            if (!DesignMode.DesignModeEnabled)
            {
                Init();
            }
            else
            {
                //디자인 타임 데이터
                BattleTags = new List<BattleTag>
                {
                    new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1417",
                        Description = "카키입니다.",
                    }
                };
            }
        }

        private void Init()
        {
            AddBattleTagCommand = new DelegateCommand(() =>
            {
                //등록 팝업 출력
                //셈플
                BattleTags = new List<BattleTag>
                {
                    new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1417",
                        Description = "카키입니다.",
                    }
                };
            });
        }

        public ICommand AddBattleTagCommand { get; set; }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            await Task.CompletedTask;
        }
    }
}
