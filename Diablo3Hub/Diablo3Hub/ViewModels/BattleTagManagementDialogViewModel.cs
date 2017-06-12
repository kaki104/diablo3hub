using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Diablo3Hub.Commons;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagManagementDialogViewModel : ViewModelBase
    {
        private string _battleTagHead;
        private string _battleTagTail;
        private string _description;
        private IList<CommonData> _realms;
        private CommonData _selectedServer;
        /// <summary>
        /// 현재 편집 중인 배틀테그 - 직접 프로퍼티에 접근하는 것을 막기 위해 private으로 사용
        /// </summary>
        private BattleTag _currentBattleTag;

        /// <summary>
        ///     생성자
        /// </summary>
        public BattleTagManagementDialogViewModel()
        {
            if (DesignMode.DesignModeEnabled)
            {
                //디자인 데이터
            }
            else
            {
                Init();
            }
        }

        /// <summary>
        ///     서버 목록 - 미국, 유럽, 아시아 3가지만
        /// </summary>
        public IList<CommonData> Realms
        {
            get => _realms;
            set => Set(ref _realms, value);
        }

        /// <summary>
        ///     선택한 서버
        /// </summary>
        public CommonData SelectedServer
        {
            get => _selectedServer;
            set => Set(ref _selectedServer, value);
        }

        /// <summary>
        ///     배틀테그 - 앞
        /// </summary>
        public string BattleTagHead
        {
            get => _battleTagHead;
            set => Set(ref _battleTagHead, value);
        }

        /// <summary>
        ///     배틀테그 - 뒤
        /// </summary>
        public string BattleTagTail
        {
            get => _battleTagTail;
            set => Set(ref _battleTagTail, value);
        }

        /// <summary>
        ///     설명
        /// </summary>
        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }
        /// <summary>
        /// OK커맨드
        /// </summary>
        public ICommand OkCommand { get; set; }
        /// <summary>
        /// Cancel커맨드
        /// </summary>
        public ICommand CancelCommand { get; set; }
        /// <summary>
        /// 초기화
        /// </summary>
        private void Init()
        {
            _currentBattleTag = new BattleTag();

            Realms = new List<CommonData>
            {
                new CommonData {Id = GameConfigs.ServerUS, Name = "US"},
                new CommonData {Id = GameConfigs.ServerEU, Name = "EU"},
                new CommonData {Id = GameConfigs.ServerKR, Name = "KR"}
            };

            OkCommand = new DelegateCommand(ExecuteOkCommand);

            CancelCommand = new DelegateCommand<object>(obj =>
            {

            });
        }
        /// <summary>
        /// ok 커맨드 실행
        /// </summary>
        private async void ExecuteOkCommand()
        {
            //커런트 배틀테그 수정
            _currentBattleTag.Server = SelectedServer?.Id;
            _currentBattleTag.Tag = $"{BattleTagHead}#{BattleTagTail}";
            if (string.IsNullOrEmpty(_currentBattleTag.Locale))
                _currentBattleTag.Locale = GameConfigs.LocaleKR;
            _currentBattleTag.Description = Description;
            //db에 업데이트
            if (IsEdit)
                await DBHelper.Instance.UpdateAsync(_currentBattleTag);
            else
                await DBHelper.Instance.InsertAsync(_currentBattleTag);
        }

        /// <summary>
        /// 편집 여부
        /// </summary>
        public bool IsEdit { get; private set; }

        /// <summary>
        /// 수정할 배틀테그 입력
        /// </summary>
        /// <param name="editTag"></param>
        public void SetBattleTag(BattleTag editTag)
        {
            var splits = editTag.Tag.Split('#');
            if (splits.Length != 2) return;

            //수정할 배틀테그를 커런트 배틀테그에 입력
            _currentBattleTag = editTag;
            IsEdit = true;
            SelectedServer = Realms.FirstOrDefault(p => p.Id == editTag.Server);
            BattleTagHead = splits.First();
            BattleTagTail = splits.Last();
            Description = editTag.Description;
        }
        /// <summary>
        /// 작업 중인 배틀테그 반환
        /// </summary>
        /// <returns></returns>
        public BattleTag GetBattleTag()
        {
            return _currentBattleTag;
        }
    }
}