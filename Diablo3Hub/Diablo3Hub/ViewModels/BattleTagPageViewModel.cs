using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Commons;
using Diablo3Hub.Controls;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Template10.Mvvm;
using System.Diagnostics;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagPageViewModel : ViewModelBase
    {
        private IList<BattleTag> _battleTags;
        private bool _isChecked;
        private ScrollHeaderMode _scrollHeaderMode;
        private ListViewSelectionMode _selectionMode;

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
                    },

                     new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1418",
                        Description = "heeya18입니다."
                    },

                     new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1419",
                        Description = "heeya19입니다."
                    },

                      new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1420",
                        Description = "heeya20입니다."
                    },

                     new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1421",
                        Description = "heeya21입니다."
                    },

                     new BattleTag
                    {
                        Server = GameConfigs.ServerKR,
                        Locale = GameConfigs.LocaleKR,
                        Tag = "SuperOwl-1422",
                        Description = "heeya22입니다."
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
        ///     선택 모드
        /// </summary>
        public ListViewSelectionMode SelectionMode
        {
            get => _selectionMode;
            set => Set(ref _selectionMode, value);
        }

        /// <summary>
        ///     선택 모드
        /// </summary>
        public bool IsChecked
        {
            get => _isChecked;
            set => Set(ref _isChecked, value);
        }
        /// <summary>
        /// 스크롤헤더 모드
        /// </summary>
        public ScrollHeaderMode ScrollHeaderMode
        {
            get => _scrollHeaderMode;
            set => Set(ref _scrollHeaderMode, value);
        }

        /// <summary>
        ///     초기화
        /// </summary>
        private void Init()
        {
            ScrollHeaderMode = ScrollHeaderMode.None;

            AddBattleTagCommand = new DelegateCommand(async () =>
            {
                //등록 팝업 출력
                var battleTag = new BattleTagManagementDialog();
                var result = await battleTag.ShowAsync();
                if (result != ContentDialogResult.Primary) return;

                //저장 되어있는 배틀테그 목록을 조회
                BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();
            });
            //셀렉트 상태로 변환
            SelectCommand = new DelegateCommand(() =>
            {
                SelectionMode = IsChecked
                    ? ListViewSelectionMode.Multiple
                    : ListViewSelectionMode.Single;
            });
            //기본 선택 모드
            SelectionMode = ListViewSelectionMode.Single;
            //수정
            EditBattleTagCommand = new DelegateCommand<object>( async obj => {

                var battelTag = obj as BattleTag;
                if (battelTag != null)
                {
                    var battleTagDialog = new BattleTagManagementDialog();
                    battleTagDialog.ViewModel.SetBattleTag(battelTag);

                    var result = await battleTagDialog.ShowAsync();
                    if (result != ContentDialogResult.Primary) return;
                }
                else
                {
                    await new Windows.UI.Popups.MessageDialog("내부적인 오류로 인해 Tag Item을 업데이트 할 수 없습니다.").ShowAsync();
                    return;
                }

            });
            //삭제
            DeleteBattleTagCommand = new DelegateCommand<object>( async obj => {
                try
                {
                    var result = await DBHelper.Instance.DeleteAsync(obj);
                    Debug.WriteLine("Delete Row Item Index : {0}", result);
                    BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();
                }
                catch (Exception)
                {
                    //To-do : 지우지 못한 Row Index에 대한 표시 필요.
                    await new Windows.UI.Popups.MessageDialog("내부적인 오류로 인해 Tag Item을 삭제 할 수 없습니다.").ShowAsync();
                    return;
                }
            });
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> state)
        {
            //네비게이트되면..
            ScrollHeaderMode = ScrollHeaderMode.Sticky;

            //저장 되어있는 배틀테그 목록을 조회
            BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();

            await Task.CompletedTask;
        }
    }
}