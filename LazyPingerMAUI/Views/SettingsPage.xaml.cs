using LazyPinger.Base.IServices;
using LazyPingerMAUI.ViewModels;

namespace LazyPingerMAUI.Views
{
    public partial class SettingsPage : ContentPage
    {
        private INetworkService _networkService { get; set; }

        private MainViewModel _mainViewModel { get; set; }

        public SettingsPage(INetworkService networkService, MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel(networkService, mainViewModel);

            _networkService = networkService;
            _mainViewModel = mainViewModel;
        }
    }

}
