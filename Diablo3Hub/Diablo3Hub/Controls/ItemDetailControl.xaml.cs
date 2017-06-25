using Windows.UI.Xaml.Controls;
using Diablo3Hub.Commons;
using Diablo3Hub.Models;
using Diablo3Hub.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Diablo3Hub.Controls
{
    public sealed partial class ItemDetailControl : UserControl, IPopupParam, IPopupResult
    {
        public ItemDetailControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 뷰모델
        /// </summary>
        public ItemDetailControlViewModel ViewModel
        {
            get => DataContext as ItemDetailControlViewModel;
            set => DataContext = value;
        }

        /// <summary>
        /// 파라메터 전달
        /// </summary>
        /// <param name="param"></param>
        public void SetParam(object param)
        {
            ViewModel.SetParam(param);
        }
        /// <summary>
        /// 결과
        /// </summary>
        public object Result { get; set; }
    }
}