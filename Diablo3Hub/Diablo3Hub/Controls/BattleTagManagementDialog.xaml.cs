using Windows.UI.Xaml.Controls;
using Diablo3Hub.ViewModels;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo3Hub.Controls
{
    public sealed partial class BattleTagManagementDialog : ContentDialog
    {
        public BattleTagManagementDialog()
        {
            InitializeComponent();
        }

        public BattleTagManagementDialogViewModel ViewModel
        {
            get => DataContext as BattleTagManagementDialogViewModel;
            set => DataContext = value;
        }
    }
}