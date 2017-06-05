using Windows.UI.Xaml.Controls;
using Diablo3Hub.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo3Hub.Views
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HeroPage : Page
    {
        public HeroPage()
        {
            InitializeComponent();
        }

        public HeroPageViewModel ViewModel
        {
            get => DataContext as HeroPageViewModel;
            set => DataContext = value;
        }
    }
}