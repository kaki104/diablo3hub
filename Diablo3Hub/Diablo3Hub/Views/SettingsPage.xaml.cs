using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Template10.Services.SerializationService;

namespace Diablo3Hub.Views
{
    public sealed partial class SettingsPage : Page
    {
        private readonly ISerializationService _SerializationService;

        public SettingsPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
            _SerializationService = SerializationService.Json;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var index = int.Parse(_SerializationService.Deserialize(e.Parameter?.ToString()).ToString());
            MyPivot.SelectedIndex = index;
        }
    }
}