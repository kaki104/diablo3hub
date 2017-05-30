using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Commons;
using Diablo3Hub.Controls;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Diablo3Hub.Views;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagPageViewModel : ViewModelBase
    {
        private IList<BattleTag> _battleTags;
        private bool _isChecked;
        private IList<BattleTag> _selectedBattleTags;
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
        ///     아이템 클릭 커맨드
        /// </summary>
        public ICommand ItemClickCommand { get; set; }

        /// <summary>
        ///     선택한 배틀테그를 삭제하는 커맨드
        /// </summary>
        public ICommand DeleteSelectedBattleTagsCommand { get; set; }

        /// <summary>
        ///     선택한 배틀테그들
        /// </summary>
        public IList<BattleTag> SelectedBattleTags
        {
            get => _selectedBattleTags;
            set => Set(ref _selectedBattleTags, value);
        }

        /// <summary>
        ///     초기화
        /// </summary>
        private void Init()
        {
            //이녀석은 ObservableCollection로 생성한 후 List로 덥어쓰지 않도록 주의한다.!!
            SelectedBattleTags = new ObservableCollection<BattleTag>();

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
                    : ListViewSelectionMode.None;
            });
            //기본 선택 모드
            SelectionMode = ListViewSelectionMode.None;
            //수정
            EditBattleTagCommand = new DelegateCommand<object>(async obj =>
            {
                var battleTag = obj as BattleTag;
                //null 체크를 한 후에는 그냥 return으로 빠져 나가는 것이 무난한 처리 방법입니다.
                if (battleTag == null) return;
                var battleTagDialog = new BattleTagManagementDialog(battleTag);
                var result = await battleTagDialog.ShowAsync();
                if (result != ContentDialogResult.Primary)
                    return;
                BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();
            });
            //삭제
            DeleteBattleTagCommand = new DelegateCommand<object>(async obj =>
            {
                var item = obj as BattleTag;
                if (item == null) return;
                var result = await CommonStaticHelper.ShowConfirmBoxAsync($"{item.Tag}를 삭제 하시겠습니까?");
                if (!result.Equals(1)) return;
                //단일 삭제 작업
                await DBHelper.Instance.DeleteAsync(item);
                //화면 데이터 갱신
                BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();
            });
            //선택 삭제, 실행 조건은 선택된 녀석이 1개 이상이여야함
            DeleteSelectedBattleTagsCommand = new DelegateCommand(() =>
            {
                //선택된 배틀테그를 삭제할지 확인하고
                //삭제한다고 하면 삭제 처리
                
            }, () => SelectedBattleTags.Count > 0);

            ItemClickCommand = new DelegateCommand<object>(obj =>
            {
                var args = obj as ItemClickEventArgs;
                var item = args.ClickedItem as BattleTag;
                if (item == null) return;

                var serializeItem = JsonConvert.SerializeObject(item);
                //히어로 페이지로 네비게이션, 네비게이션 파라메터도 넘기고..
                NavigationService.Navigate(typeof(BattleTagDetailPage), serializeItem);
            });
            //선택이 변경된 경우
            SelectionChangedCommand = new DelegateCommand(() =>
            {
                ((DelegateCommand)DeleteSelectedBattleTagsCommand).RaiseCanExecuteChanged();
            });
        }
        /// <summary>
        /// 선택 변경 커맨드 - 선택이 변경되면 삭제 버튼의 사용 가능 여부를 확인해 주어야함
        /// </summary>
        public ICommand SelectionChangedCommand { get; set; }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> state)
        {
            //네비게이트되면..

            //저장 되어있는 배틀테그 목록을 조회
            BattleTags = await DBHelper.Instance.BattleTagTable().ToListAsync();

            await Task.CompletedTask;
        }
    }
}