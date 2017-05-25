using Windows.UI.Xaml.Controls;
using Diablo3Hub.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo3Hub.Views
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BattleTagDetailPage : Page
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public BattleTagDetailPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 뷰모델
        /// </summary>
        public BattleTagDetailPageViewModel ViewModel
        {
            get => DataContext as BattleTagDetailPageViewModel;
            set => DataContext = value;
        }
    }
}