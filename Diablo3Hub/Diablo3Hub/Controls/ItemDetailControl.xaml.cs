using Windows.UI.Xaml.Controls;
using Diablo3Hub.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Diablo3Hub.Controls
{
    public sealed partial class ItemDetailControl : UserControl
    {
        public ItemDetailControl()
        {
            InitializeComponent();
        }

        public ItemDetailControlViewModel ViewModel
        {
            get => DataContext as ItemDetailControlViewModel;
            set => DataContext = value;
        }
    }
}