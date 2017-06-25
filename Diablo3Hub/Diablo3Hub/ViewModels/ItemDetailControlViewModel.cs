using System.Windows.Input;
using Windows.ApplicationModel;
using Diablo3Hub.Commons;
using Diablo3Hub.DesignDatas;
using Diablo3Hub.Models;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class ItemDetailControlViewModel : ViewModelBase, IPopupParam, IPopupResult
    {
        private ItemDetail _currentItem;

        /// <summary>
        ///     기본생성자
        /// </summary>
        public ItemDetailControlViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                CurrentItem = DesignData.GetItemDetail();
            else
                Init();
        }

        /// <summary>
        ///     현재 아이템
        /// </summary>
        public ItemDetail CurrentItem
        {
            get => _currentItem;
            set => Set(ref _currentItem, value);
        }

        /// <summary>
        ///     초기화
        /// </summary>
        private void Init()
        {

        }

        public ICommand SaveCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// 파라메터 전달
        /// </summary>
        /// <param name="param"></param>
        public void SetParam(object param)
        {
            CurrentItem = param as ItemDetail;
        }
        /// <summary>
        /// 결과
        /// </summary>
        public object Result { get; set; }
    }
}