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
    public class BattleTagItemDelConfirmDialogViewModel: ViewModelBase
    {

        private IList<BattleTag> _selectedBattleTags;

        /// <summary>
        ///     생성자
        /// </summary>
        public BattleTagItemDelConfirmDialogViewModel()
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
        ///     선택한 배틀테그들
        /// </summary>
        public IList<BattleTag> SelectedBattleTags
        {
            get => _selectedBattleTags;
            set => Set(ref _selectedBattleTags, value);
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
            if (SelectedBattleTags.Count > 0)
            {
                var selTags = SelectedBattleTags.ToList<BattleTag>();
                await DBHelper.Instance.DeleteTagItemsAsync(selTags);
            }

        }
    }
}
