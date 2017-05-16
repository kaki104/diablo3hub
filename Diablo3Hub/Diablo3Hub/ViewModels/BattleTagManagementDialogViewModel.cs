using System.Collections.Generic;
using System.Windows.Input;
using Windows.ApplicationModel;
using Diablo3Hub.Commons;
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

        private void Init()
        {
            Realms = new List<CommonData>
            {
                new CommonData {Id = GameConfigs.ServerUS, Name = "US"},
                new CommonData {Id = GameConfigs.ServerEU, Name = "EU"},
                new CommonData {Id = GameConfigs.ServerKR, Name = "KR"}
            };

            OkCommand = new DelegateCommand<object>(obj =>
            {
                
            });
            CancelCommand = new DelegateCommand<object>(obj =>
            {

            });
        }
    }
}