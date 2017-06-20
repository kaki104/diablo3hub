using Windows.ApplicationModel;
using Diablo3Hub.DesignDatas;
using Diablo3Hub.Models;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class ItemDetailControlViewModel : ViewModelBase
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
    }
}