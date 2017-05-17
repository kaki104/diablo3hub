using Windows.UI.Xaml.Controls;
using Diablo3Hub.Models;
using Diablo3Hub.ViewModels;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo3Hub.Controls
{
    public sealed partial class BattleTagManagementDialog : ContentDialog
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public BattleTagManagementDialog()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 추가 생성자
        /// </summary>
        /// <param name="editTag"></param>
        public BattleTagManagementDialog(BattleTag editTag) : this()
        {
            
        }

        public BattleTagManagementDialogViewModel ViewModel
        {
            get => DataContext as BattleTagManagementDialogViewModel;
            set => DataContext = value;
        }
    }
}