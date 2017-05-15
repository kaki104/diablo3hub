using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Commons;
using Diablo3Hub.Controls;
using Diablo3Hub.Models;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagPageViewModel : ViewModelBase
    {
        private IList<BattleTag> _battleTags;

        public BattleTagPageViewModel()
        {
            if (!DesignMode.DesignModeEnabled)
                Init();
            else
                BattleTags = new List<BattleTag>
                {
                    new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1417",
                        Description = "카키입니다."
                    }
                };
        }

        /// <summary>
        ///     배틀 테그 목록
        /// </summary>
        public IList<BattleTag> BattleTags
        {
            get => _battleTags;
            set => Set(ref _battleTags, value);
        }

        /// <summary>
        ///     베틀테그 추가 커맨드
        /// </summary>
        public ICommand AddBattleTagCommand { get; set; }

        /// <summary>
        ///     배틀테그 수정 커맨드
        /// </summary>
        public ICommand EditBattleTagCommand { get; set; }

        /// <summary>
        ///     배틀테그 삭제 커맨드
        /// </summary>
        public ICommand DeleteBattleTagCommand { get; set; }

        /// <summary>
        ///     선택하기 커맨드
        /// </summary>
        public ICommand SelectCommand { get; set; }

        /// <summary>
        ///     초기화
        /// </summary>
        private void Init()
        {
            AddBattleTagCommand = new DelegateCommand(async () =>
            {
                ////등록 팝업 출력
                ////셈플
                //BattleTags = new List<BattleTag>
                //{
                //    new BattleTag
                //    {
                //        Server = GameConfigs.ServerKR,
                //        Locale = GameConfigs.LocaleKR,
                //        Tag = "SuperOwl-1417",
                //        Description = "카키입니다."
                //    },
                //    new BattleTag
                //    {
                //        Server = GameConfigs.ServerKR,
                //        Locale = GameConfigs.LocaleKR,
                //        Tag = "SuperOwl-1417",
                //        Description = "카키입니다."
                //    },
                //    new BattleTag
                //    {
                //        Server = GameConfigs.ServerKR,
                //        Locale = GameConfigs.LocaleKR,
                //        Tag = "SuperOwl-1417",
                //        Description = "카키입니다."
                //    }
                //};
                var battleTag = new BattleTagManagementDialog();
                var result = await battleTag.ShowAsync();
            });
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> state)
        {
            await Task.CompletedTask;
        }
    }
}